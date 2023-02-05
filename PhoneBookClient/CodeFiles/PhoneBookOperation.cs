// phone book page operations

using Microsoft.AspNetCore.Components;
using PhoneBookService;

namespace PhoneBookClient.CodeFiles
{
    public partial class PhoneBookOperation : ComponentBase
    {
        protected ContactList? contactList;
        protected int? SelectedId { get; set; } // selected contact id, to display 
        protected ContactData? SelectedContact { get; set; } // selected contact to display
        private string? _searchText;
        protected string? SearchText { get { return _searchText != null ? _searchText.ToLower() : ""; } set { _searchText = value; } }
        protected bool ShowDialog { get; set; } // show delete confirmation dialog
        protected int DeleteContactId { get; set; }

        protected bool ShowError { get; set; } // show error alert
        protected string? ErrorMsg { get; set; } // error msg
        protected string? ErrorTitle { get; set; } = "Error"; // error title


        [Inject]
        protected Services.ContactDataService ContactService { get; set; } = default!;
        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        protected async override Task OnInitializedAsync()
        {
            await GetContactList();
        }

        // get contact list
        protected async Task GetContactList()
        {
            try
            {
                contactList = await ContactService.GetContactList();
            }
            catch (Exception ex)
            {
                ErrorTitle = "Error - GetContactList()";
                ErrorMsg = ex.Message;
                ShowError = true;
            }
        }

        // callback for delete confirmation modal dialog
        protected async Task DeleteConfirmed(int id)
        {
            ShowDialog = false;
            await DeleteContact(id);
        }

        // delte the contact
        protected async Task DeleteContact(int id)
        {
            try
            {
                var operationStatus = await ContactService.DeleteContact(id);
                SelectedContact = null;
                SelectedId = null;

                // refresh contact list after contact delete
                await GetContactList();
            }
            catch (Exception ex)
            {
                ErrorTitle = "Error - DeleteContact()";
                ErrorMsg = ex.Message;
                ShowError = true;
            }

        }


    }
 
}

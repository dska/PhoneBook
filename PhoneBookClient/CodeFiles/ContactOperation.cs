// contact edit form page operations

using Microsoft.AspNetCore.Components;
using PhoneBookService;

namespace PhoneBookClient.CodeFiles
{
    public partial class ContactOperation : ComponentBase
    {
        [Parameter]
        public int? ContactId { get; set; } // passed id

        [Parameter]
        public ContactData? Contact { get; set; } // passed contact data


        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        protected Services.ContactDataService ContactService { get; set; } = default!;

        //[Inject]
        //IJSRuntime JSRuntime { get; set; } = default!;

        protected bool ShowDialog { get; set; } // show delete confirmation dialog

        protected bool ShowError { get; set; } // show error alert
        protected string? ErrorMsg { get; set; } // error msg

        protected async override Task OnInitializedAsync()
        {
            // show contact if exists or prepare new to add
            if(ContactId != null)
            {
                if(ContactId.Value > 0)
                    await GetContact(ContactId.Value);
                else
                    Contact = new ContactData();
            }
            else
            {
                Contact = new ContactData(); 
            }
        }

        // get contact
        protected async Task GetContact(int Id)
        {
            try
            {
                Contact = await ContactService.GetContactData(Id);
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
                ShowError = true;
            }
        }

        // add contact
        protected async Task AddContact()
        {
            if (Contact != null)
            {
                try
                {
                    var response = await ContactService.AddContactData(Contact!);

                    // get the id of newly created contact if successfull insert
                    if (response.StatusCode == 100) // successfull insert
                    {
                        ContactId = response.Id;
                        Contact.Id = response.Id;
                        // refresh id in URL
                        NavigationManager.NavigateTo("/contactedit/" + ContactId);
                    }
                    // error during insert
                    else
                    {
                        ErrorMsg = response.StatusMessage;
                        ShowError = true;
                    }
                }
                catch (Exception ex)
                {
                    ErrorMsg = ex.Message;
                    ShowError = true;
                }
            }
        }

        // update contact
        protected async Task UpdateContact()
        {
            if(Contact != null)
            {
                try
                {
                    var status = await ContactService.UpdateContact(Contact!);
                    // NavigationManager.NavigateTo("/phonebook");
                }
                catch (Exception ex)
                {
                    ErrorMsg = ex.Message;
                    ShowError = true;
                }
            }
        }

        // call back method in delete confirmation modal dialog
        protected async Task DeleteConfirmed()
        {
            ShowDialog = false;
            await DeleteContact();
        }

        // delete the contact
        public async Task DeleteContact()
        {
            if(Contact != null)
            {
                //bool result = await JSRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to delete the contact?");

                //if (result)
                //{
                try
                {
                    var operationStatus = await ContactService.DeleteContact(Contact.Id);
                    NavigationManager.NavigateTo("/phonebook");
                }
                catch(Exception ex)
                {
                    ErrorMsg = ex.Message;
                    ShowError = true;
                }
                //}
            }
        }

    }
 
}

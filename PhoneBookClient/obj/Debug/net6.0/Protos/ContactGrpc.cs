// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/contact.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PhoneBookService {
  /// <summary>
  /// grpc methods for get, add, update and delete contact
  /// </summary>
  public static partial class PhoneBook
  {
    static readonly string __ServiceName = "PhoneBook.PhoneBook";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PhoneBookService.ContactList> __Marshaller_PhoneBook_ContactList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PhoneBookService.ContactList.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PhoneBookService.ContactQuery> __Marshaller_PhoneBook_ContactQuery = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PhoneBookService.ContactQuery.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PhoneBookService.ContactData> __Marshaller_PhoneBook_ContactData = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PhoneBookService.ContactData.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PhoneBookService.ContactPostResponse> __Marshaller_PhoneBook_ContactPostResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PhoneBookService.ContactPostResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PhoneBookService.ContactUpdateQuery> __Marshaller_PhoneBook_ContactUpdateQuery = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PhoneBookService.ContactUpdateQuery.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::PhoneBookService.ContactList> __Method_GetContactList = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::PhoneBookService.ContactList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetContactList",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_PhoneBook_ContactList);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PhoneBookService.ContactQuery, global::PhoneBookService.ContactData> __Method_GetContact = new grpc::Method<global::PhoneBookService.ContactQuery, global::PhoneBookService.ContactData>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetContact",
        __Marshaller_PhoneBook_ContactQuery,
        __Marshaller_PhoneBook_ContactData);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PhoneBookService.ContactData, global::PhoneBookService.ContactPostResponse> __Method_AddContact = new grpc::Method<global::PhoneBookService.ContactData, global::PhoneBookService.ContactPostResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddContact",
        __Marshaller_PhoneBook_ContactData,
        __Marshaller_PhoneBook_ContactPostResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PhoneBookService.ContactUpdateQuery, global::PhoneBookService.ContactPostResponse> __Method_UpdateContact = new grpc::Method<global::PhoneBookService.ContactUpdateQuery, global::PhoneBookService.ContactPostResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateContact",
        __Marshaller_PhoneBook_ContactUpdateQuery,
        __Marshaller_PhoneBook_ContactPostResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PhoneBookService.ContactQuery, global::PhoneBookService.ContactPostResponse> __Method_DeleteContact = new grpc::Method<global::PhoneBookService.ContactQuery, global::PhoneBookService.ContactPostResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteContact",
        __Marshaller_PhoneBook_ContactQuery,
        __Marshaller_PhoneBook_ContactPostResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PhoneBookService.ContactReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for PhoneBook</summary>
    public partial class PhoneBookClient : grpc::ClientBase<PhoneBookClient>
    {
      /// <summary>Creates a new client for PhoneBook</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PhoneBookClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PhoneBook that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PhoneBookClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PhoneBookClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PhoneBookClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PhoneBookService.ContactList GetContactList(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetContactList(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PhoneBookService.ContactList GetContactList(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetContactList, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PhoneBookService.ContactList> GetContactListAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetContactListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PhoneBookService.ContactList> GetContactListAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetContactList, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PhoneBookService.ContactData GetContact(global::PhoneBookService.ContactQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetContact(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PhoneBookService.ContactData GetContact(global::PhoneBookService.ContactQuery request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetContact, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PhoneBookService.ContactData> GetContactAsync(global::PhoneBookService.ContactQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetContactAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PhoneBookService.ContactData> GetContactAsync(global::PhoneBookService.ContactQuery request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetContact, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PhoneBookService.ContactPostResponse AddContact(global::PhoneBookService.ContactData request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddContact(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PhoneBookService.ContactPostResponse AddContact(global::PhoneBookService.ContactData request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddContact, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PhoneBookService.ContactPostResponse> AddContactAsync(global::PhoneBookService.ContactData request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddContactAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PhoneBookService.ContactPostResponse> AddContactAsync(global::PhoneBookService.ContactData request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddContact, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PhoneBookService.ContactPostResponse UpdateContact(global::PhoneBookService.ContactUpdateQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateContact(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PhoneBookService.ContactPostResponse UpdateContact(global::PhoneBookService.ContactUpdateQuery request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateContact, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PhoneBookService.ContactPostResponse> UpdateContactAsync(global::PhoneBookService.ContactUpdateQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateContactAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PhoneBookService.ContactPostResponse> UpdateContactAsync(global::PhoneBookService.ContactUpdateQuery request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateContact, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PhoneBookService.ContactPostResponse DeleteContact(global::PhoneBookService.ContactQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteContact(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PhoneBookService.ContactPostResponse DeleteContact(global::PhoneBookService.ContactQuery request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteContact, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PhoneBookService.ContactPostResponse> DeleteContactAsync(global::PhoneBookService.ContactQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteContactAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PhoneBookService.ContactPostResponse> DeleteContactAsync(global::PhoneBookService.ContactQuery request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteContact, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override PhoneBookClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PhoneBookClient(configuration);
      }
    }

  }
}
#endregion

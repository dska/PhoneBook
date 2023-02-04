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

    /// <summary>Base class for server-side implementations of PhoneBook</summary>
    [grpc::BindServiceMethod(typeof(PhoneBook), "BindService")]
    public abstract partial class PhoneBookBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PhoneBookService.ContactList> GetContactList(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PhoneBookService.ContactData> GetContact(global::PhoneBookService.ContactQuery request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PhoneBookService.ContactPostResponse> AddContact(global::PhoneBookService.ContactData request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PhoneBookService.ContactPostResponse> UpdateContact(global::PhoneBookService.ContactUpdateQuery request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PhoneBookService.ContactPostResponse> DeleteContact(global::PhoneBookService.ContactQuery request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(PhoneBookBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetContactList, serviceImpl.GetContactList)
          .AddMethod(__Method_GetContact, serviceImpl.GetContact)
          .AddMethod(__Method_AddContact, serviceImpl.AddContact)
          .AddMethod(__Method_UpdateContact, serviceImpl.UpdateContact)
          .AddMethod(__Method_DeleteContact, serviceImpl.DeleteContact).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PhoneBookBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetContactList, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::PhoneBookService.ContactList>(serviceImpl.GetContactList));
      serviceBinder.AddMethod(__Method_GetContact, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PhoneBookService.ContactQuery, global::PhoneBookService.ContactData>(serviceImpl.GetContact));
      serviceBinder.AddMethod(__Method_AddContact, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PhoneBookService.ContactData, global::PhoneBookService.ContactPostResponse>(serviceImpl.AddContact));
      serviceBinder.AddMethod(__Method_UpdateContact, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PhoneBookService.ContactUpdateQuery, global::PhoneBookService.ContactPostResponse>(serviceImpl.UpdateContact));
      serviceBinder.AddMethod(__Method_DeleteContact, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PhoneBookService.ContactQuery, global::PhoneBookService.ContactPostResponse>(serviceImpl.DeleteContact));
    }

  }
}
#endregion
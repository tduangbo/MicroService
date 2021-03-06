// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: eventcatalog.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GloboTicket.Grpc {
  public static partial class Events
  {
    static readonly string __ServiceName = "API.Events";

    static readonly grpc::Marshaller<global::GloboTicket.Grpc.GetAllEventsRequest> __Marshaller_API_GetAllEventsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GloboTicket.Grpc.GetAllEventsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GloboTicket.Grpc.GetAllEventsResponse> __Marshaller_API_GetAllEventsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GloboTicket.Grpc.GetAllEventsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GloboTicket.Grpc.GetAllEventsByCategoryIdRequest> __Marshaller_API_GetAllEventsByCategoryIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GloboTicket.Grpc.GetAllEventsByCategoryIdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GloboTicket.Grpc.GetByEventIdRequest> __Marshaller_API_GetByEventIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GloboTicket.Grpc.GetByEventIdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GloboTicket.Grpc.GetByEventIdResponse> __Marshaller_API_GetByEventIdResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GloboTicket.Grpc.GetByEventIdResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GloboTicket.Grpc.GetAllCategoriesRequest> __Marshaller_API_GetAllCategoriesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GloboTicket.Grpc.GetAllCategoriesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GloboTicket.Grpc.GetAllCategoriesResponse> __Marshaller_API_GetAllCategoriesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GloboTicket.Grpc.GetAllCategoriesResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::GloboTicket.Grpc.GetAllEventsRequest, global::GloboTicket.Grpc.GetAllEventsResponse> __Method_GetAll = new grpc::Method<global::GloboTicket.Grpc.GetAllEventsRequest, global::GloboTicket.Grpc.GetAllEventsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_API_GetAllEventsRequest,
        __Marshaller_API_GetAllEventsResponse);

    static readonly grpc::Method<global::GloboTicket.Grpc.GetAllEventsByCategoryIdRequest, global::GloboTicket.Grpc.GetAllEventsResponse> __Method_GetAllByCategoryId = new grpc::Method<global::GloboTicket.Grpc.GetAllEventsByCategoryIdRequest, global::GloboTicket.Grpc.GetAllEventsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllByCategoryId",
        __Marshaller_API_GetAllEventsByCategoryIdRequest,
        __Marshaller_API_GetAllEventsResponse);

    static readonly grpc::Method<global::GloboTicket.Grpc.GetByEventIdRequest, global::GloboTicket.Grpc.GetByEventIdResponse> __Method_GetByEventId = new grpc::Method<global::GloboTicket.Grpc.GetByEventIdRequest, global::GloboTicket.Grpc.GetByEventIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetByEventId",
        __Marshaller_API_GetByEventIdRequest,
        __Marshaller_API_GetByEventIdResponse);

    static readonly grpc::Method<global::GloboTicket.Grpc.GetAllCategoriesRequest, global::GloboTicket.Grpc.GetAllCategoriesResponse> __Method_GetAllCategories = new grpc::Method<global::GloboTicket.Grpc.GetAllCategoriesRequest, global::GloboTicket.Grpc.GetAllCategoriesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllCategories",
        __Marshaller_API_GetAllCategoriesRequest,
        __Marshaller_API_GetAllCategoriesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GloboTicket.Grpc.EventcatalogReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Events</summary>
    [grpc::BindServiceMethod(typeof(Events), "BindService")]
    public abstract partial class EventsBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GloboTicket.Grpc.GetAllEventsResponse> GetAll(global::GloboTicket.Grpc.GetAllEventsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GloboTicket.Grpc.GetAllEventsResponse> GetAllByCategoryId(global::GloboTicket.Grpc.GetAllEventsByCategoryIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GloboTicket.Grpc.GetByEventIdResponse> GetByEventId(global::GloboTicket.Grpc.GetByEventIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GloboTicket.Grpc.GetAllCategoriesResponse> GetAllCategories(global::GloboTicket.Grpc.GetAllCategoriesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(EventsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAll, serviceImpl.GetAll)
          .AddMethod(__Method_GetAllByCategoryId, serviceImpl.GetAllByCategoryId)
          .AddMethod(__Method_GetByEventId, serviceImpl.GetByEventId)
          .AddMethod(__Method_GetAllCategories, serviceImpl.GetAllCategories).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, EventsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GloboTicket.Grpc.GetAllEventsRequest, global::GloboTicket.Grpc.GetAllEventsResponse>(serviceImpl.GetAll));
      serviceBinder.AddMethod(__Method_GetAllByCategoryId, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GloboTicket.Grpc.GetAllEventsByCategoryIdRequest, global::GloboTicket.Grpc.GetAllEventsResponse>(serviceImpl.GetAllByCategoryId));
      serviceBinder.AddMethod(__Method_GetByEventId, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GloboTicket.Grpc.GetByEventIdRequest, global::GloboTicket.Grpc.GetByEventIdResponse>(serviceImpl.GetByEventId));
      serviceBinder.AddMethod(__Method_GetAllCategories, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GloboTicket.Grpc.GetAllCategoriesRequest, global::GloboTicket.Grpc.GetAllCategoriesResponse>(serviceImpl.GetAllCategories));
    }

  }
}
#endregion

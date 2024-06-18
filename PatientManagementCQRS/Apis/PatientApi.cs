namespace PatientManagementCQRS.Apis;

public static class PatientApi
{
	public static RouteGroupBuilder MapPatientsApiV1(this IEndpointRouteBuilder app)
	{
		var api = app.MapGroup("api/patients");

		//api.MapPut("/cancel", CancelOrderAsync);
		//api.MapPut("/ship", ShipOrderAsync);
		//api.MapGet("{orderId:int}", GetOrderAsync);
		//api.MapGet("/", GetOrdersByUserAsync);
		//api.MapGet("/cardtypes", GetCardTypesAsync);
		//api.MapPost("/draft", CreateOrderDraftAsync);
		//api.MapPost("/", CreateOrderAsync);

		return api;
	}
}
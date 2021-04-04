namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statuscode, string message = null)
        {
            StatusCode = statuscode; 
            Message = message;
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, you have made",
                401 => "Authorised, you are not",
                404 => "Resource found, it was not",
                500 => "Awutsi nami ngibhale kwami lengikufunako lana. Angitsi lomitha naye wenta lakufunako",
                _ => null

            };
        }
    }
}
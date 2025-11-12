namespace GymTrainerGuide.Web.Repositories
{
    public class HttpResponseWrapper<T>
    {
        public HttpResponseWrapper(T? response, bool error, HttpResponseMessage httpResponse)
        {
            Response = response;
            Error = error;
            HttpResponse = httpResponse;
        }

        public T? Response { get; set; }
        public bool Error { get; set; }
        public HttpResponseMessage HttpResponse { get; set; }

        public async Task<string> GetErrorMessage()
        {
            if (!Error)
                return string.Empty;

            return await HttpResponse.Content.ReadAsStringAsync();
        }
    }
}

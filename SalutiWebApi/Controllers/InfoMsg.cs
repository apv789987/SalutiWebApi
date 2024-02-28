namespace SalutiWebApi.Controllers
{
    public class InfoMsg
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public string Date { get; set; }  

        public InfoMsg(string code, String message)
        {
            this.Code = code;
            this.Message = message;
            this.Date = DateTime.Now.ToString();
        }
    }
}

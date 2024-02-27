namespace SalutiWebApi.Controllers
{
    public class InfoMsg
    {
        public string Code { get; set; }
        public string Message { get; set; }

        public InfoMsg(string Code, String Message)
        {
            this.Code = Code;
            this.Message = Message;
        }
    }
}

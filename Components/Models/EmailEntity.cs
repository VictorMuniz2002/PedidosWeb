using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace PedidosWeb.Components.Models
{
    public class EmailEntity
    {

        public string FromEmailAdress { get; set; }
        public string ToEmailAdress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        [ValidateNever]
        public string AttacmentURL { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using WebClinica.Comum.Validacao;

namespace WebClinica.Web.CustomValidatorUI
{
    public class CustomValidationCNPJAtribute : ValidationAttribute, IClientValidatable
    {
        public override bool IsValid(object value)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
                return true;

            bool valido = Util.ValidaCnpj(value.ToString());
            return valido;
        }
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRule
            {
                ErrorMessage = this.FormatErrorMessage("CNPJ Inválido!"),
                ValidationType = "customvalidationcpf"
            };
        }
    }
}
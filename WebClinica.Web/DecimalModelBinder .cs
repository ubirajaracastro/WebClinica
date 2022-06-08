using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClinica.Web
{
    public class DecimalModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            #region comentado
            //ValueProviderResult valueResult =
            //    bindingContext.ValueProvider
            //        .GetValue(bindingContext.ModelName);
            //ModelState modelState =
            //    new ModelState { Value = valueResult };


            //object actualValue = null;
            //try
            //{
            //    actualValue = Convert.ToDecimal(
            //        valueResult.AttemptedValue,
            //        CultureInfo.CurrentCulture);
            //}
            //catch (FormatException e)
            //{
            //    modelState.Errors.Add(e);
            //}

            //bindingContext.ModelState.Add(
            //    bindingContext.ModelName, modelState);
            //return actualValue;
            #endregion

            object result = null;
            object actualValue = null;

            // Don't do this here!
            // It might do bindingContext.ModelState.AddModelError
            // and there is no RemoveModelError!
            // 
            // result = base.BindModel(controllerContext, bindingContext);

            string modelName = bindingContext.ModelName;
            string attemptedValue =
                bindingContext.ValueProvider.GetValue(modelName).AttemptedValue;

            // Depending on CultureInfo, the NumberDecimalSeparator can be "," or "."
            // Both "." and "," should be accepted, but aren't.
            string wantedSeperator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
            string alternateSeperator = (wantedSeperator == "," ? "." : ",");

            if (attemptedValue.IndexOf(wantedSeperator) == -1
                && attemptedValue.IndexOf(alternateSeperator) != -1)
            {
                attemptedValue =
                    attemptedValue.Replace(alternateSeperator, wantedSeperator);
            }
            
             actualValue = Convert.ToDecimal(attemptedValue, CultureInfo.CurrentCulture);

            try
            {
                if (bindingContext.ModelMetadata.IsNullableValueType
                    && string.IsNullOrWhiteSpace(attemptedValue))
                {
                    return null;
                }

                result = actualValue;
                //result = decimal.Parse(attemptedValue, NumberStyles.Any);
            }
            catch (FormatException e)
            {
                bindingContext.ModelState.AddModelError(modelName, e);
            }

            return result;

        }
    }
}
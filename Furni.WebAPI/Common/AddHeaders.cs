using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.OpenApi.Models;


namespace Furni.WebAPI.Common
{
    public class AddHeaders : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null) operation.Parameters = new List<OpenApiParameter>();

            operation.Parameters.Add(new OpenApiParameter()
            {
                Name = "LOGIN_ID",
                In = ParameterLocation.Header,
                Required = false
            });

            operation.Parameters.Add(new OpenApiParameter()
            {
                Name = "TOKEN_NO",
                In = ParameterLocation.Header,
                Required = false
            });

            operation.Parameters.Add(new OpenApiParameter()
            {
                Name = "user_Id",
                In = ParameterLocation.Header,
                Required = false
            });
        }
    }
}

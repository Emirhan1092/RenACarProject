﻿using Core.Utilities.Results;
using FluentValidation;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation
{
    public class ValidationTool

    {
        public static void Validate(IValidator validator,object entitiy)
        { 
        var context = new ValidationContext<object>(entitiy);
        var result = validator.Validate(context);    
            if(!result.IsValid) 
            {
                throw new ValidationException(result.Errors);

    } }
}
}
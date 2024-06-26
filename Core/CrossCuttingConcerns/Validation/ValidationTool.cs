﻿using FluentValidation;

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

﻿using Core.Utilities.Results;

namespace Core.Utilities.Buisness
{
    public class BuisnessRules
    {

        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics) 
            
            
            { 
                if(!logic.Success)
                {
                    return logic;
                }

            
            
            
            
            }
            return null;
        }

       
    }
}

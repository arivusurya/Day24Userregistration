using System;
using System.Text.RegularExpressions;


namespace UserValidation{

    public class User{

            public Boolean ValidateName(string firstName){   
               String Pattern = "[A-Z]{1}[a-z]{2,}";
               if(Regex.IsMatch(firstName,Pattern))
               {
                return true;
                 }else{
                    throw new UserException("username is not valid");
               }
               
            }

            public Boolean Validatemail(string email){
                string Pattern ="^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-][a-zA-Z0-9]+)*.[a-zA-Z]{2,}$";
                if(Regex.IsMatch(email,Pattern)){
                    return true;
                }else
                {
                    throw new UserException("Not valid email");
                }
            }

            public Boolean validNumber(string Number){
                string Pattern = "^91 [0-9]{10}";
                if(Regex.IsMatch(Number,Pattern)){
                    return true;
                }else{
                    throw new UserException("not a valid Number");
                }
            }
             public Boolean validPassWord(string Password){
                string Pattern = "^(?=.*[A-Z])(?=.*\\d)(?=.*[@#$%*.&]).{8,}$";
                if(Regex.IsMatch(Password,Pattern)){
                    return true;
                }else
                {
                    throw new UserException("Not a valid password");
                }
            }

      
        }

    }


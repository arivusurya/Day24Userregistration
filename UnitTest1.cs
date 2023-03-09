namespace valid;
using UserValidation;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        User user = new User();
        string validemails = "abc@yahoo.com";
        string name = "Ares";
        string mobileNum= "91 8580959085";


        
        Boolean expected = true;
        bool isname = user.ValidateName(name);
        bool isemail = user.Validatemail(validemails);
        bool isnumber = user.validNumber(mobileNum);
       
       Assert.AreEqual(expected,isname);
       Assert.AreEqual(expected,isemail);
       Assert.AreEqual(expected,isnumber);



     

        
        }
    }
 

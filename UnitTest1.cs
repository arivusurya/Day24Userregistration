namespace valid;
using UserValidation;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1(string email,bool expected)
    {
        User user = new User();
       
       List<(string, bool)> testData = new List<(string, bool)>
    {
    ("abc@yahoo.com", true),
    ("abc-100@yahoo.com", true),
    ("abc111@abc.com", true),
    ("test@example", false),
    ("test@domain.", false),
    ("test@domain..com", false),
    
    };


    foreach (var data in testData)
{
    string myemail = data.Item1;
    bool expectedOutput = data.Item2;

    bool actualOutput = user.Validatemail(myemail);

    Assert.AreEqual(expectedOutput, actualOutput);
}
    


     

        
    }
    }
 

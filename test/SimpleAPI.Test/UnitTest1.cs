using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    ValuesController controller = new();


    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("Bufaonanet test", returnValue);    
    }
}
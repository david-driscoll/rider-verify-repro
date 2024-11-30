namespace MyTest;

public class MyTest
{
    [Fact]
    public Task ThisIsATestThatDoesntWorkInRiderWithVerify()
    {
        return Verify(new { result = true });
    }
}
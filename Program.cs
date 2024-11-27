namespace MyTest;

class MyTest
{
    [Test]
    public Task ThisIsATestThatDoesntWorkInRiderWithVerify()
    {
        return Verify(new { result = true });
    }
}
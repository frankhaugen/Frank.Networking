namespace Frank.Networking.Tests;

public abstract class BaseTest
{
    protected readonly ITestOutputHelper _outputHelper;

    protected BaseTest(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

}
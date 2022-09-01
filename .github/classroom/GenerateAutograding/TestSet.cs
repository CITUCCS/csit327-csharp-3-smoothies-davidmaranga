namespace GenerateAutograding;

internal sealed class TestSet
{
    private readonly string _startupProject;

    public TestSet(string startupProject) => _startupProject = startupProject;

    public IReadOnlyList<Test> Tests => new Test[]
    {
        new DotnetTestGroup("SmoothieConstructor")
        {
            Points = 10
        },
        new DotnetTestGroup("SmoothieIngredients")
        {
            Points = 10
        },
        new DotnetTestGroup("SmoothieName")
        {
            Points = 10
        },
        new DotnetTestGroup("SmoothieGetCost")
        {
            Points = 10
        },
        new DotnetTestGroup("SmoothieGetPrice")
        {
            Points = 10
        },
    };
}

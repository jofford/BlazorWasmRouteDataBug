namespace BlazorWasm1.Pages;

public partial class ThingList : IDisposable
{
    Guid id1 = Guid.NewGuid();
    Guid id2 = Guid.NewGuid();

    public ThingList()
    {
        Console.WriteLine("ThingList constructed: {0}", GetHashCode());
    }

    public void Dispose()
    {
        Console.WriteLine("ThingList disposing: {0}", GetHashCode());
    }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        Console.WriteLine("ThingList OnInitialized: {0}", GetHashCode());
    }
}

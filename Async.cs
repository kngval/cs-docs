public class Async {

    public async Task<int> ExampleMethodAsync()
    {
        await httpClient.GetStringAsync("");
    }
}
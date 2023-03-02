# FastEndpoints Possible Bug
e 
 When using XUnit and clicking "Run All" with multiple tests using IClassFixtures, one IClassFixture will fail.

 This only appears to happen when multiple PreProcessors have been configured for an endpoint.

 To Reproduce:

 1. Clone, click "Run All" in Test Explorer
 2. See one test class using `IClassFixture` fails.
 3. Comment out or delete the PreProcessors in IndexEndpoint/Endpoint
 4. Click "Run All" in Test Explorer
 5. All tests pass.
﻿namespace Deepgram.Tests.IntegrationTests;
public class EndpointTests
{
    public string ApiKey = "";


    //[Test]
    //public async Task GetAsync_Should_Return_ExpectedResult_On_SuccessfulResponse()
    //{
    //    // Arrange        
    //    var serviceCollection = new ServiceCollection();
    //    serviceCollection.AddHttpClient();
    //    var serviceProvider = serviceCollection.BuildServiceProvider();
    //    var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();

    //    var client = new ManageClient(ApiKey, new DeepgramClientOptions(), httpClientFactory);


    //    // Act
    //    var result = await client.GetProjects();

    //    // Assert
    //    Assert.That(result, Is.Not.Null);

    //    // Assert.That(result.Projects.Length, Is.EqualTo(excpectedResult.Projects.Length));
    //}

    //[Test]
    //public async Task PostTest()
    //{
    //    var source = new UrlSource { Url = "https://static.deepgram.com/examples/Bueller-Life-moves-pretty-fast.wav" };
    //    var options = new PrerecordedSchema { Punctuate = true, Utterances = true };
    //    var ops = QueryParameterUtil.GetParameters(options);
    //    var uriSegment = $"{Constants.API_VERSION}/{Constants.TRANSCRIPTION_URI_SEGMENT}?{ops}";

    //    var httpClient = new HttpClient();
    //    var client = new ConcreteRestClient(ApiKey, new DeepgramClientOptions(), httpClient);
    //    client.Logger = Substitute.For<ILogger<ConcreteRestClient>>();

    //    // Act
    //    var result = await client.PostAsync<SyncPrerecordedResponse, UrlSource>(uriSegment, source);


    //    Assert.That(result, Is.Not.Null);
    //}


    //[Test]
    //public async Task PostTest()
    //{

    //    var options = new ExpirationOptions { Comment = "Test", Scopes = new string[] { "member" }, ExpirationDate = DateTime.Now.AddDays(2) };

    //    //var options = new TimeToLiveOptions { Comment = "Test", Scopes = new string[] { "member" }, TimeToLiveInSeconds = 6000 };

    //    // var ops = QueryParameterUtil.GetParameters(options);
    //    var projectURI = $"{Constants.PROJECTS_URI_SEGMENT}";


    //    var httpClient = new HttpClient();
    //    var client = new ConcreteRestClient(ApiKey, new DeepgramClientOptions(), httpClient);
    //    client.Logger = Substitute.For<ILogger<ConcreteRestClient>>();
    //    var projResult = await client.GetAsync<GetProjectsResponse>(projectURI);
    //    var projectId = projResult.Projects[0].ProjectId;
    //    var keyURi = $"{projectURI}/{projectId}/keys";

    //    // Act
    //    var result = await client.PostAsync<CreateProjectKeyResponse, ExpirationOptions>(keyURi, options);
    //    //var result = await client.PostAsync<CreateProjectKeyResponse, TimeToLiveOptions>(keyURi, options);

    //    Assert.That(result, Is.Not.Null);
    //}

}

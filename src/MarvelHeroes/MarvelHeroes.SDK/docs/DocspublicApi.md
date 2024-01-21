# MarvelHeroes.SDK.Api.DocspublicApi

All URIs are relative to *http://gateway.marvel.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharacterEventsCollection**](DocspublicApi.md#getcharactereventscollection) | **GET** /v1/public/characters/{characterId}/events | Fetches lists of events filtered by a character id.
[**GetCharacterIndividual**](DocspublicApi.md#getcharacterindividual) | **GET** /v1/public/characters/{characterId} | Fetches a single character by id.
[**GetCharacterSeriesCollection**](DocspublicApi.md#getcharacterseriescollection) | **GET** /v1/public/characters/{characterId}/series | Fetches lists of series filtered by a character id.
[**GetCharacterStoryCollection**](DocspublicApi.md#getcharacterstorycollection) | **GET** /v1/public/characters/{characterId}/stories | Fetches lists of stories filtered by a character id.
[**GetComicCharacterCollection**](DocspublicApi.md#getcomiccharactercollection) | **GET** /v1/public/comics/{comicId}/characters | Fetches lists of characters filtered by a comic id.
[**GetComicIndividual**](DocspublicApi.md#getcomicindividual) | **GET** /v1/public/comics/{comicId} | Fetches a single comic by id.
[**GetComicStoryCollection**](DocspublicApi.md#getcomicstorycollection) | **GET** /v1/public/comics/{comicId}/stories | Fetches lists of stories filtered by a comic id.
[**GetComicsCharacterCollection**](DocspublicApi.md#getcomicscharactercollection) | **GET** /v1/public/characters/{characterId}/comics | Fetches lists of comics filtered by a character id.
[**GetComicsCollection**](DocspublicApi.md#getcomicscollection) | **GET** /v1/public/creators/{creatorId}/comics | Fetches lists of comics filtered by a creator id.
[**GetComicsCollection_0**](DocspublicApi.md#getcomicscollection_0) | **GET** /v1/public/events/{eventId}/comics | Fetches lists of comics filtered by an event id.
[**GetComicsCollection_1**](DocspublicApi.md#getcomicscollection_1) | **GET** /v1/public/series/{seriesId}/comics | Fetches lists of comics filtered by a series id.
[**GetComicsCollection_2**](DocspublicApi.md#getcomicscollection_2) | **GET** /v1/public/comics | Fetches lists of comics.
[**GetComicsCollection_3**](DocspublicApi.md#getcomicscollection_3) | **GET** /v1/public/stories/{storyId}/comics | Fetches lists of comics filtered by a story id.
[**GetCreatorCollection**](DocspublicApi.md#getcreatorcollection) | **GET** /v1/public/creators | Fetches lists of creators.
[**GetCreatorCollection_0**](DocspublicApi.md#getcreatorcollection_0) | **GET** /v1/public/stories/{storyId}/characters | Fetches lists of characters filtered by a story id.
[**GetCreatorCollection_1**](DocspublicApi.md#getcreatorcollection_1) | **GET** /v1/public/series/{seriesId}/creators | Fetches lists of creators filtered by a series id.
[**GetCreatorCollection_2**](DocspublicApi.md#getcreatorcollection_2) | **GET** /v1/public/comics/{comicId}/creators | Fetches lists of creators filtered by a comic id.
[**GetCreatorCollection_3**](DocspublicApi.md#getcreatorcollection_3) | **GET** /v1/public/characters | Fetches lists of characters.
[**GetCreatorCollection_4**](DocspublicApi.md#getcreatorcollection_4) | **GET** /v1/public/stories/{storyId}/creators | Fetches lists of creators filtered by a story id.
[**GetCreatorCollection_5**](DocspublicApi.md#getcreatorcollection_5) | **GET** /v1/public/events/{eventId}/creators | Fetches lists of creators filtered by an event id.
[**GetCreatorEventsCollection**](DocspublicApi.md#getcreatoreventscollection) | **GET** /v1/public/creators/{creatorId}/events | Fetches lists of events filtered by a creator id.
[**GetCreatorIndividual**](DocspublicApi.md#getcreatorindividual) | **GET** /v1/public/creators/{creatorId} | Fetches a single creator by id.
[**GetCreatorSeriesCollection**](DocspublicApi.md#getcreatorseriescollection) | **GET** /v1/public/creators/{creatorId}/series | Fetches lists of series filtered by a creator id.
[**GetCreatorStoryCollection**](DocspublicApi.md#getcreatorstorycollection) | **GET** /v1/public/creators/{creatorId}/stories | Fetches lists of stories filtered by a creator id.
[**GetEventCharacterCollection**](DocspublicApi.md#geteventcharactercollection) | **GET** /v1/public/events/{eventId}/characters | Fetches lists of characters filtered by an event id.
[**GetEventIndividual**](DocspublicApi.md#geteventindividual) | **GET** /v1/public/events/{eventId} | Fetches a single event by id.
[**GetEventSeriesCollection**](DocspublicApi.md#geteventseriescollection) | **GET** /v1/public/events/{eventId}/series | Fetches lists of series filtered by an event id.
[**GetEventStoryCollection**](DocspublicApi.md#geteventstorycollection) | **GET** /v1/public/events/{eventId}/stories | Fetches lists of stories filtered by an event id.
[**GetEventsCollection**](DocspublicApi.md#geteventscollection) | **GET** /v1/public/stories/{storyId}/events | Fetches lists of events filtered by a story id.
[**GetEventsCollection_0**](DocspublicApi.md#geteventscollection_0) | **GET** /v1/public/series/{seriesId}/events | Fetches lists of events filtered by a series id.
[**GetEventsCollection_1**](DocspublicApi.md#geteventscollection_1) | **GET** /v1/public/events | Fetches lists of events.
[**GetIssueEventsCollection**](DocspublicApi.md#getissueeventscollection) | **GET** /v1/public/comics/{comicId}/events | Fetches lists of events filtered by a comic id.
[**GetSeriesCharacterWrapper**](DocspublicApi.md#getseriescharacterwrapper) | **GET** /v1/public/series/{seriesId}/characters | Fetches lists of characters filtered by a series id.
[**GetSeriesCollection**](DocspublicApi.md#getseriescollection) | **GET** /v1/public/series | Fetches lists of series.
[**GetSeriesIndividual**](DocspublicApi.md#getseriesindividual) | **GET** /v1/public/series/{seriesId} | Fetches a single comic series by id.
[**GetSeriesStoryCollection**](DocspublicApi.md#getseriesstorycollection) | **GET** /v1/public/series/{seriesId}/stories | Fetches lists of stories filtered by a series id.
[**GetStoryCollection**](DocspublicApi.md#getstorycollection) | **GET** /v1/public/stories | Fetches lists of stories.
[**GetStoryIndividual**](DocspublicApi.md#getstoryindividual) | **GET** /v1/public/stories/{storyId} | Fetches a single comic story by id.
[**GetStorySeriesCollection**](DocspublicApi.md#getstoryseriescollection) | **GET** /v1/public/stories/{storyId}/series | Fetches lists of series filtered by a story id.

<a name="getcharactereventscollection"></a>
# **GetCharacterEventsCollection**
> void GetCharacterEventsCollection (int? characterId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> creators, List<int?> series, List<int?> comics, List<int?> stories, List<string> orderBy, int? limit, int? offset)

Fetches lists of events filtered by a character id.

Fetches lists of events in which a specific character appears, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetCharacterEventsCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var characterId = 56;  // int? | The character ID.
            var name = name_example;  // string | Filter the event list by name. (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Return events with names that begin with the specified string (e.g. Sp). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only events which have been modified since the specified date. (optional) 
            var creators = new List<int?>(); // List<int?> | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only events which are part of the specified series (accepts a comma-separated list of ids). (optional) 
            var comics = new List<int?>(); // List<int?> | Return only events which take place in the specified comics (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only events which contain the specified stories (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of events filtered by a character id.
                apiInstance.GetCharacterEventsCollection(characterId, name, nameStartsWith, modifiedSince, creators, series, comics, stories, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetCharacterEventsCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| The character ID. | 
 **name** | **string**| Filter the event list by name. | [optional] 
 **nameStartsWith** | **string**| Return events with names that begin with the specified string (e.g. Sp). | [optional] 
 **modifiedSince** | **DateTime?**| Return only events which have been modified since the specified date. | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only events which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only events which are part of the specified series (accepts a comma-separated list of ids). | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only events which take place in the specified comics (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only events which contain the specified stories (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterindividual"></a>
# **GetCharacterIndividual**
> void GetCharacterIndividual (int? characterId)

Fetches a single character by id.

This method fetches a single character resource.  It is the canonical URI for any character resource provided by the API.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetCharacterIndividualExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var characterId = 56;  // int? | A single character id.

            try
            {
                // Fetches a single character by id.
                apiInstance.GetCharacterIndividual(characterId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetCharacterIndividual: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| A single character id. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterseriescollection"></a>
# **GetCharacterSeriesCollection**
> void GetCharacterSeriesCollection (int? characterId, string title, string titleStartsWith, int? startYear, DateTime? modifiedSince, List<int?> comics, List<int?> stories, List<int?> events, List<int?> creators, string seriesType, List<string> contains, List<string> orderBy, int? limit, int? offset)

Fetches lists of series filtered by a character id.

Fetches lists of comic series in which a specific character appears, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetCharacterSeriesCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var characterId = 56;  // int? | The character ID
            var title = title_example;  // string | Filter by series title. (optional) 
            var titleStartsWith = titleStartsWith_example;  // string | Return series with titles that begin with the specified string (e.g. Sp). (optional) 
            var startYear = 56;  // int? | Return only series matching the specified start year. (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only series which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only series which contain the specified comics (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only series which contain the specified stories (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). (optional) 
            var creators = new List<int?>(); // List<int?> | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var seriesType = seriesType_example;  // string | Filter the series by publication frequency type. (optional) 
            var contains = new List<string>(); // List<string> | Return only series containing one or more comics with the specified format. (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of series filtered by a character id.
                apiInstance.GetCharacterSeriesCollection(characterId, title, titleStartsWith, startYear, modifiedSince, comics, stories, events, creators, seriesType, contains, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetCharacterSeriesCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| The character ID | 
 **title** | **string**| Filter by series title. | [optional] 
 **titleStartsWith** | **string**| Return series with titles that begin with the specified string (e.g. Sp). | [optional] 
 **startYear** | **int?**| Return only series matching the specified start year. | [optional] 
 **modifiedSince** | **DateTime?**| Return only series which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only series which contain the specified comics (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only series which contain the specified stories (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only series which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **seriesType** | **string**| Filter the series by publication frequency type. | [optional] 
 **contains** | [**List<string>**](string.md)| Return only series containing one or more comics with the specified format. | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterstorycollection"></a>
# **GetCharacterStoryCollection**
> void GetCharacterStoryCollection (int? characterId, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<int?> creators, List<string> orderBy, int? limit, int? offset)

Fetches lists of stories filtered by a character id.

Fetches lists of comic stories  featuring a specific character with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetCharacterStoryCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var characterId = 56;  // int? | The character ID.
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only stories which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only stories contained in the specified (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only stories contained the specified series (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only stories which take place during the specified events (accepts a comma-separated list of ids). (optional) 
            var creators = new List<int?>(); // List<int?> | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of stories filtered by a character id.
                apiInstance.GetCharacterStoryCollection(characterId, modifiedSince, comics, series, events, creators, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetCharacterStoryCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| The character ID. | 
 **modifiedSince** | **DateTime?**| Return only stories which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only stories contained in the specified (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only stories contained the specified series (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only stories which take place during the specified events (accepts a comma-separated list of ids). | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomiccharactercollection"></a>
# **GetComicCharacterCollection**
> void GetComicCharacterCollection (int? comicId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> series, List<int?> events, List<int?> stories, List<string> orderBy, int? limit, int? offset)

Fetches lists of characters filtered by a comic id.

Fetches lists of characters which appear in a specific comic with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetComicCharacterCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var comicId = 56;  // int? | The comic id.
            var name = name_example;  // string | Return only characters matching the specified full character name (e.g. Spider-Man). (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Return characters with names that begin with the specified string (e.g. Sp). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only characters which have been modified since the specified date. (optional) 
            var series = new List<int?>(); // List<int?> | Return only characters which appear the specified series (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only characters which appear the specified stories (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of characters filtered by a comic id.
                apiInstance.GetComicCharacterCollection(comicId, name, nameStartsWith, modifiedSince, series, events, stories, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetComicCharacterCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **comicId** | **int?**| The comic id. | 
 **name** | **string**| Return only characters matching the specified full character name (e.g. Spider-Man). | [optional] 
 **nameStartsWith** | **string**| Return characters with names that begin with the specified string (e.g. Sp). | [optional] 
 **modifiedSince** | **DateTime?**| Return only characters which have been modified since the specified date. | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only characters which appear the specified series (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only characters which appear the specified stories (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomicindividual"></a>
# **GetComicIndividual**
> void GetComicIndividual (int? comicId)

Fetches a single comic by id.

This method fetches a single comic resource.  It is the canonical URI for any comic resource provided by the API.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetComicIndividualExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var comicId = 56;  // int? | A single comic.

            try
            {
                // Fetches a single comic by id.
                apiInstance.GetComicIndividual(comicId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetComicIndividual: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **comicId** | **int?**| A single comic. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomicstorycollection"></a>
# **GetComicStoryCollection**
> void GetComicStoryCollection (int? comicId, DateTime? modifiedSince, List<int?> series, List<int?> events, List<int?> creators, List<int?> characters, List<string> orderBy, int? limit, int? offset)

Fetches lists of stories filtered by a comic id.

Fetches lists of comic stories in a specific comic issue, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetComicStoryCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var comicId = 56;  // int? | The comic ID.
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only stories which have been modified since the specified date. (optional) 
            var series = new List<int?>(); // List<int?> | Return only stories contained the specified series (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only stories which take place during the specified events (accepts a comma-separated list of ids). (optional) 
            var creators = new List<int?>(); // List<int?> | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only stories which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources. (optional) 

            try
            {
                // Fetches lists of stories filtered by a comic id.
                apiInstance.GetComicStoryCollection(comicId, modifiedSince, series, events, creators, characters, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetComicStoryCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **comicId** | **int?**| The comic ID. | 
 **modifiedSince** | **DateTime?**| Return only stories which have been modified since the specified date. | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only stories contained the specified series (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only stories which take place during the specified events (accepts a comma-separated list of ids). | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only stories which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomicscharactercollection"></a>
# **GetComicsCharacterCollection**
> void GetComicsCharacterCollection (int? characterId, string format, string formatType, bool? noVariants, string dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, bool? hasDigitalIssue, DateTime? modifiedSince, List<int?> creators, List<int?> series, List<int?> events, List<int?> stories, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset)

Fetches lists of comics filtered by a character id.

Fetches lists of comics containing a specific character, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetComicsCharacterCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var characterId = 56;  // int? | The character id.
            var format = format_example;  // string | Filter by the issue format (e.g. comic, digital comic, hardcover). (optional) 
            var formatType = formatType_example;  // string | Filter by the issue format type (comic or collection). (optional) 
            var noVariants = true;  // bool? | Exclude variant comics from the result set. (optional) 
            var dateDescriptor = dateDescriptor_example;  // string | Return comics within a predefined date range. (optional) 
            var dateRange = new List<int?>(); // List<int?> | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. (optional) 
            var title = title_example;  // string | Return only issues in series whose title matches the input. (optional) 
            var titleStartsWith = titleStartsWith_example;  // string | Return only issues in series whose title starts with the input. (optional) 
            var startYear = 56;  // int? | Return only issues in series whose start year matches the input. (optional) 
            var issueNumber = 56;  // int? | Return only issues in series whose issue number matches the input. (optional) 
            var diamondCode = diamondCode_example;  // string | Filter by diamond code. (optional) 
            var digitalId = 56;  // int? | Filter by digital comic id. (optional) 
            var upc = upc_example;  // string | Filter by UPC. (optional) 
            var isbn = isbn_example;  // string | Filter by ISBN. (optional) 
            var ean = ean_example;  // string | Filter by EAN. (optional) 
            var issn = issn_example;  // string | Filter by ISSN. (optional) 
            var hasDigitalIssue = true;  // bool? | Include only results which are available digitally. (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only comics which have been modified since the specified date. (optional) 
            var creators = new List<int?>(); // List<int?> | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only comics which are part of the specified series (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only comics which take place in the specified events (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only comics which contain the specified stories (accepts a comma-separated list of ids). (optional) 
            var sharedAppearances = new List<int?>(); // List<int?> | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). (optional) 
            var collaborators = new List<int?>(); // List<int?> | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of comics filtered by a character id.
                apiInstance.GetComicsCharacterCollection(characterId, format, formatType, noVariants, dateDescriptor, dateRange, title, titleStartsWith, startYear, issueNumber, diamondCode, digitalId, upc, isbn, ean, issn, hasDigitalIssue, modifiedSince, creators, series, events, stories, sharedAppearances, collaborators, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetComicsCharacterCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| The character id. | 
 **format** | **string**| Filter by the issue format (e.g. comic, digital comic, hardcover). | [optional] 
 **formatType** | **string**| Filter by the issue format type (comic or collection). | [optional] 
 **noVariants** | **bool?**| Exclude variant comics from the result set. | [optional] 
 **dateDescriptor** | **string**| Return comics within a predefined date range. | [optional] 
 **dateRange** | [**List<int?>**](int?.md)| Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. | [optional] 
 **title** | **string**| Return only issues in series whose title matches the input. | [optional] 
 **titleStartsWith** | **string**| Return only issues in series whose title starts with the input. | [optional] 
 **startYear** | **int?**| Return only issues in series whose start year matches the input. | [optional] 
 **issueNumber** | **int?**| Return only issues in series whose issue number matches the input. | [optional] 
 **diamondCode** | **string**| Filter by diamond code. | [optional] 
 **digitalId** | **int?**| Filter by digital comic id. | [optional] 
 **upc** | **string**| Filter by UPC. | [optional] 
 **isbn** | **string**| Filter by ISBN. | [optional] 
 **ean** | **string**| Filter by EAN. | [optional] 
 **issn** | **string**| Filter by ISSN. | [optional] 
 **hasDigitalIssue** | **bool?**| Include only results which are available digitally. | [optional] 
 **modifiedSince** | **DateTime?**| Return only comics which have been modified since the specified date. | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only comics which are part of the specified series (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only comics which take place in the specified events (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only comics which contain the specified stories (accepts a comma-separated list of ids). | [optional] 
 **sharedAppearances** | [**List<int?>**](int?.md)| Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). | [optional] 
 **collaborators** | [**List<int?>**](int?.md)| Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomicscollection"></a>
# **GetComicsCollection**
> void GetComicsCollection (int? creatorId, string format, string formatType, bool? noVariants, string dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, List<bool?> hasDigitalIssue, DateTime? modifiedSince, List<int?> characters, List<int?> series, List<int?> events, List<int?> stories, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset)

Fetches lists of comics filtered by a creator id.

Fetches lists of comics in which the work of a specific creator appears, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetComicsCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var creatorId = 56;  // int? | The creator ID.
            var format = format_example;  // string | Filter by the issue format (e.g. comic, digital comic, hardcover). (optional) 
            var formatType = formatType_example;  // string | Filter by the issue format type (comic or collection). (optional) 
            var noVariants = true;  // bool? | Exclude variant comics from the result set. (optional) 
            var dateDescriptor = dateDescriptor_example;  // string | Return comics within a predefined date range. (optional) 
            var dateRange = new List<int?>(); // List<int?> | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. (optional) 
            var title = title_example;  // string | Return only issues in series whose title matches the input. (optional) 
            var titleStartsWith = titleStartsWith_example;  // string | Return only issues in series whose title starts with the input. (optional) 
            var startYear = 56;  // int? | Return only issues in series whose start year matches the input. (optional) 
            var issueNumber = 56;  // int? | Return only issues in series whose issue number matches the input. (optional) 
            var diamondCode = diamondCode_example;  // string | Filter by diamond code. (optional) 
            var digitalId = 56;  // int? | Filter by digital comic id. (optional) 
            var upc = upc_example;  // string | Filter by UPC. (optional) 
            var isbn = isbn_example;  // string | Filter by ISBN. (optional) 
            var ean = ean_example;  // string | Filter by EAN. (optional) 
            var issn = issn_example;  // string | Filter by ISSN. (optional) 
            var hasDigitalIssue = new List<bool?>(); // List<bool?> | Include only results which are available digitally. (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only comics which have been modified since the specified date. (optional) 
            var characters = new List<int?>(); // List<int?> | Return only comics which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only comics which are part of the specified series (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only comics which take place in the specified events (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only comics which contain the specified stories (accepts a comma-separated list of ids). (optional) 
            var sharedAppearances = new List<int?>(); // List<int?> | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). (optional) 
            var collaborators = new List<int?>(); // List<int?> | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of comics filtered by a creator id.
                apiInstance.GetComicsCollection(creatorId, format, formatType, noVariants, dateDescriptor, dateRange, title, titleStartsWith, startYear, issueNumber, diamondCode, digitalId, upc, isbn, ean, issn, hasDigitalIssue, modifiedSince, characters, series, events, stories, sharedAppearances, collaborators, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetComicsCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **creatorId** | **int?**| The creator ID. | 
 **format** | **string**| Filter by the issue format (e.g. comic, digital comic, hardcover). | [optional] 
 **formatType** | **string**| Filter by the issue format type (comic or collection). | [optional] 
 **noVariants** | **bool?**| Exclude variant comics from the result set. | [optional] 
 **dateDescriptor** | **string**| Return comics within a predefined date range. | [optional] 
 **dateRange** | [**List<int?>**](int?.md)| Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. | [optional] 
 **title** | **string**| Return only issues in series whose title matches the input. | [optional] 
 **titleStartsWith** | **string**| Return only issues in series whose title starts with the input. | [optional] 
 **startYear** | **int?**| Return only issues in series whose start year matches the input. | [optional] 
 **issueNumber** | **int?**| Return only issues in series whose issue number matches the input. | [optional] 
 **diamondCode** | **string**| Filter by diamond code. | [optional] 
 **digitalId** | **int?**| Filter by digital comic id. | [optional] 
 **upc** | **string**| Filter by UPC. | [optional] 
 **isbn** | **string**| Filter by ISBN. | [optional] 
 **ean** | **string**| Filter by EAN. | [optional] 
 **issn** | **string**| Filter by ISSN. | [optional] 
 **hasDigitalIssue** | [**List<bool?>**](bool?.md)| Include only results which are available digitally. | [optional] 
 **modifiedSince** | **DateTime?**| Return only comics which have been modified since the specified date. | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only comics which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only comics which are part of the specified series (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only comics which take place in the specified events (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only comics which contain the specified stories (accepts a comma-separated list of ids). | [optional] 
 **sharedAppearances** | [**List<int?>**](int?.md)| Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). | [optional] 
 **collaborators** | [**List<int?>**](int?.md)| Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomicscollection_0"></a>
# **GetComicsCollection_0**
> void GetComicsCollection_0 (int? eventId, string format, string formatType, List<bool?> noVariants, List<string> dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, List<bool?> hasDigitalIssue, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> events, List<int?> stories, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset)

Fetches lists of comics filtered by an event id.

Fetches lists of comics which take place during a specific event, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetComicsCollection_0Example
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var eventId = 56;  // int? | The event id.
            var format = format_example;  // string | Filter by the issue format (e.g. comic, digital comic, hardcover). (optional) 
            var formatType = formatType_example;  // string | Filter by the issue format type (comic or collection). (optional) 
            var noVariants = new List<bool?>(); // List<bool?> | Exclude variant comics from the result set. (optional) 
            var dateDescriptor = new List<string>(); // List<string> | Return comics within a predefined date range. (optional) 
            var dateRange = new List<int?>(); // List<int?> | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. (optional) 
            var title = title_example;  // string | Return only issues in series whose title matches the input. (optional) 
            var titleStartsWith = titleStartsWith_example;  // string | Return only issues in series whose title starts with the input. (optional) 
            var startYear = 56;  // int? | Return only issues in series whose start year matches the input. (optional) 
            var issueNumber = 56;  // int? | Return only issues in series whose issue number matches the input. (optional) 
            var diamondCode = diamondCode_example;  // string | Filter by diamond code. (optional) 
            var digitalId = 56;  // int? | Filter by digital comic id. (optional) 
            var upc = upc_example;  // string | Filter by UPC. (optional) 
            var isbn = isbn_example;  // string | Filter by ISBN. (optional) 
            var ean = ean_example;  // string | Filter by EAN. (optional) 
            var issn = issn_example;  // string | Filter by ISSN. (optional) 
            var hasDigitalIssue = new List<bool?>(); // List<bool?> | Include only results which are available digitally. (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only comics which have been modified since the specified date. (optional) 
            var creators = new List<int?>(); // List<int?> | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only comics which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only comics which are part of the specified series (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only comics which take place in the specified events (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only comics which contain the specified stories (accepts a comma-separated list of ids). (optional) 
            var sharedAppearances = new List<int?>(); // List<int?> | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). (optional) 
            var collaborators = new List<int?>(); // List<int?> | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of comics filtered by an event id.
                apiInstance.GetComicsCollection_0(eventId, format, formatType, noVariants, dateDescriptor, dateRange, title, titleStartsWith, startYear, issueNumber, diamondCode, digitalId, upc, isbn, ean, issn, hasDigitalIssue, modifiedSince, creators, characters, series, events, stories, sharedAppearances, collaborators, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetComicsCollection_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **int?**| The event id. | 
 **format** | **string**| Filter by the issue format (e.g. comic, digital comic, hardcover). | [optional] 
 **formatType** | **string**| Filter by the issue format type (comic or collection). | [optional] 
 **noVariants** | [**List<bool?>**](bool?.md)| Exclude variant comics from the result set. | [optional] 
 **dateDescriptor** | [**List<string>**](string.md)| Return comics within a predefined date range. | [optional] 
 **dateRange** | [**List<int?>**](int?.md)| Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. | [optional] 
 **title** | **string**| Return only issues in series whose title matches the input. | [optional] 
 **titleStartsWith** | **string**| Return only issues in series whose title starts with the input. | [optional] 
 **startYear** | **int?**| Return only issues in series whose start year matches the input. | [optional] 
 **issueNumber** | **int?**| Return only issues in series whose issue number matches the input. | [optional] 
 **diamondCode** | **string**| Filter by diamond code. | [optional] 
 **digitalId** | **int?**| Filter by digital comic id. | [optional] 
 **upc** | **string**| Filter by UPC. | [optional] 
 **isbn** | **string**| Filter by ISBN. | [optional] 
 **ean** | **string**| Filter by EAN. | [optional] 
 **issn** | **string**| Filter by ISSN. | [optional] 
 **hasDigitalIssue** | [**List<bool?>**](bool?.md)| Include only results which are available digitally. | [optional] 
 **modifiedSince** | **DateTime?**| Return only comics which have been modified since the specified date. | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only comics which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only comics which are part of the specified series (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only comics which take place in the specified events (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only comics which contain the specified stories (accepts a comma-separated list of ids). | [optional] 
 **sharedAppearances** | [**List<int?>**](int?.md)| Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). | [optional] 
 **collaborators** | [**List<int?>**](int?.md)| Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomicscollection_1"></a>
# **GetComicsCollection_1**
> void GetComicsCollection_1 (int? seriesId, string format, string formatType, List<bool?> noVariants, List<string> dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, List<bool?> hasDigitalIssue, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> events, List<int?> stories, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset)

Fetches lists of comics filtered by a series id.

Fetches lists of comics which are published as part of a specific series, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetComicsCollection_1Example
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var seriesId = 56;  // int? | The series ID.
            var format = format_example;  // string | Filter by the issue format (e.g. comic, digital comic, hardcover). (optional) 
            var formatType = formatType_example;  // string | Filter by the issue format type (comic or collection). (optional) 
            var noVariants = new List<bool?>(); // List<bool?> | Exclude variant comics from the result set. (optional) 
            var dateDescriptor = new List<string>(); // List<string> | Return comics within a predefined date range. (optional) 
            var dateRange = new List<int?>(); // List<int?> | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. (optional) 
            var title = title_example;  // string | Return only issues in series whose title matches the input. (optional) 
            var titleStartsWith = titleStartsWith_example;  // string | Return only issues in series whose title starts with the input. (optional) 
            var startYear = 56;  // int? | Return only issues in series whose start year matches the input. (optional) 
            var issueNumber = 56;  // int? | Return only issues in series whose issue number matches the input. (optional) 
            var diamondCode = diamondCode_example;  // string | Filter by diamond code. (optional) 
            var digitalId = 56;  // int? | Filter by digital comic id. (optional) 
            var upc = upc_example;  // string | Filter by UPC. (optional) 
            var isbn = isbn_example;  // string | Filter by ISBN. (optional) 
            var ean = ean_example;  // string | Filter by EAN. (optional) 
            var issn = issn_example;  // string | Filter by ISSN. (optional) 
            var hasDigitalIssue = new List<bool?>(); // List<bool?> | Include only results which are available digitally. (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only comics which have been modified since the specified date. (optional) 
            var creators = new List<int?>(); // List<int?> | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only comics which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only comics which take place in the specified events (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only comics which contain the specified stories (accepts a comma-separated list of ids). (optional) 
            var sharedAppearances = new List<int?>(); // List<int?> | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). (optional) 
            var collaborators = new List<int?>(); // List<int?> | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of comics filtered by a series id.
                apiInstance.GetComicsCollection_1(seriesId, format, formatType, noVariants, dateDescriptor, dateRange, title, titleStartsWith, startYear, issueNumber, diamondCode, digitalId, upc, isbn, ean, issn, hasDigitalIssue, modifiedSince, creators, characters, events, stories, sharedAppearances, collaborators, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetComicsCollection_1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **seriesId** | **int?**| The series ID. | 
 **format** | **string**| Filter by the issue format (e.g. comic, digital comic, hardcover). | [optional] 
 **formatType** | **string**| Filter by the issue format type (comic or collection). | [optional] 
 **noVariants** | [**List<bool?>**](bool?.md)| Exclude variant comics from the result set. | [optional] 
 **dateDescriptor** | [**List<string>**](string.md)| Return comics within a predefined date range. | [optional] 
 **dateRange** | [**List<int?>**](int?.md)| Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. | [optional] 
 **title** | **string**| Return only issues in series whose title matches the input. | [optional] 
 **titleStartsWith** | **string**| Return only issues in series whose title starts with the input. | [optional] 
 **startYear** | **int?**| Return only issues in series whose start year matches the input. | [optional] 
 **issueNumber** | **int?**| Return only issues in series whose issue number matches the input. | [optional] 
 **diamondCode** | **string**| Filter by diamond code. | [optional] 
 **digitalId** | **int?**| Filter by digital comic id. | [optional] 
 **upc** | **string**| Filter by UPC. | [optional] 
 **isbn** | **string**| Filter by ISBN. | [optional] 
 **ean** | **string**| Filter by EAN. | [optional] 
 **issn** | **string**| Filter by ISSN. | [optional] 
 **hasDigitalIssue** | [**List<bool?>**](bool?.md)| Include only results which are available digitally. | [optional] 
 **modifiedSince** | **DateTime?**| Return only comics which have been modified since the specified date. | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only comics which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only comics which take place in the specified events (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only comics which contain the specified stories (accepts a comma-separated list of ids). | [optional] 
 **sharedAppearances** | [**List<int?>**](int?.md)| Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). | [optional] 
 **collaborators** | [**List<int?>**](int?.md)| Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomicscollection_2"></a>
# **GetComicsCollection_2**
> void GetComicsCollection_2 (string format, string formatType, bool? noVariants, string dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, bool? hasDigitalIssue, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> events, List<int?> stories, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset)

Fetches lists of comics.

Fetches lists of comics with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetComicsCollection_2Example
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var format = format_example;  // string | Filter by the issue format (e.g. comic, digital comic, hardcover). (optional) 
            var formatType = formatType_example;  // string | Filter by the issue format type (comic or collection). (optional) 
            var noVariants = true;  // bool? | Exclude variants (alternate covers, secondary printings, director's cuts, etc.) from the result set. (optional) 
            var dateDescriptor = dateDescriptor_example;  // string | Return comics within a predefined date range. (optional) 
            var dateRange = new List<int?>(); // List<int?> | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. (optional) 
            var title = title_example;  // string | Return only issues in series whose title matches the input. (optional) 
            var titleStartsWith = titleStartsWith_example;  // string | Return only issues in series whose title starts with the input. (optional) 
            var startYear = 56;  // int? | Return only issues in series whose start year matches the input. (optional) 
            var issueNumber = 56;  // int? | Return only issues in series whose issue number matches the input. (optional) 
            var diamondCode = diamondCode_example;  // string | Filter by diamond code. (optional) 
            var digitalId = 56;  // int? | Filter by digital comic id. (optional) 
            var upc = upc_example;  // string | Filter by UPC. (optional) 
            var isbn = isbn_example;  // string | Filter by ISBN. (optional) 
            var ean = ean_example;  // string | Filter by EAN. (optional) 
            var issn = issn_example;  // string | Filter by ISSN. (optional) 
            var hasDigitalIssue = true;  // bool? | Include only results which are available digitally. (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only comics which have been modified since the specified date. (optional) 
            var creators = new List<int?>(); // List<int?> | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only comics which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only comics which are part of the specified series (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only comics which take place in the specified events (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only comics which contain the specified stories (accepts a comma-separated list of ids). (optional) 
            var sharedAppearances = new List<int?>(); // List<int?> | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). Accepts a comma-separated list of ids. (optional) 
            var collaborators = new List<int?>(); // List<int?> | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). Accepts a comma-separated list of ids. (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of comics.
                apiInstance.GetComicsCollection_2(format, formatType, noVariants, dateDescriptor, dateRange, title, titleStartsWith, startYear, issueNumber, diamondCode, digitalId, upc, isbn, ean, issn, hasDigitalIssue, modifiedSince, creators, characters, series, events, stories, sharedAppearances, collaborators, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetComicsCollection_2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Filter by the issue format (e.g. comic, digital comic, hardcover). | [optional] 
 **formatType** | **string**| Filter by the issue format type (comic or collection). | [optional] 
 **noVariants** | **bool?**| Exclude variants (alternate covers, secondary printings, director&#x27;s cuts, etc.) from the result set. | [optional] 
 **dateDescriptor** | **string**| Return comics within a predefined date range. | [optional] 
 **dateRange** | [**List<int?>**](int?.md)| Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. | [optional] 
 **title** | **string**| Return only issues in series whose title matches the input. | [optional] 
 **titleStartsWith** | **string**| Return only issues in series whose title starts with the input. | [optional] 
 **startYear** | **int?**| Return only issues in series whose start year matches the input. | [optional] 
 **issueNumber** | **int?**| Return only issues in series whose issue number matches the input. | [optional] 
 **diamondCode** | **string**| Filter by diamond code. | [optional] 
 **digitalId** | **int?**| Filter by digital comic id. | [optional] 
 **upc** | **string**| Filter by UPC. | [optional] 
 **isbn** | **string**| Filter by ISBN. | [optional] 
 **ean** | **string**| Filter by EAN. | [optional] 
 **issn** | **string**| Filter by ISSN. | [optional] 
 **hasDigitalIssue** | **bool?**| Include only results which are available digitally. | [optional] 
 **modifiedSince** | **DateTime?**| Return only comics which have been modified since the specified date. | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only comics which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only comics which are part of the specified series (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only comics which take place in the specified events (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only comics which contain the specified stories (accepts a comma-separated list of ids). | [optional] 
 **sharedAppearances** | [**List<int?>**](int?.md)| Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). Accepts a comma-separated list of ids. | [optional] 
 **collaborators** | [**List<int?>**](int?.md)| Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). Accepts a comma-separated list of ids. | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomicscollection_3"></a>
# **GetComicsCollection_3**
> void GetComicsCollection_3 (int? storyId, string format, string formatType, List<bool?> noVariants, List<string> dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, List<bool?> hasDigitalIssue, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> events, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset)

Fetches lists of comics filtered by a story id.

Fetches lists of comics in which a specific story appears, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetComicsCollection_3Example
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var storyId = 56;  // int? | The story ID.
            var format = format_example;  // string | Filter by the issue format (e.g. comic, digital comic, hardcover). (optional) 
            var formatType = formatType_example;  // string | Filter by the issue format type (comic or collection). (optional) 
            var noVariants = new List<bool?>(); // List<bool?> | Exclude variant comics from the result set. (optional) 
            var dateDescriptor = new List<string>(); // List<string> | Return comics within a predefined date range. (optional) 
            var dateRange = new List<int?>(); // List<int?> | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. (optional) 
            var title = title_example;  // string | Return only issues in series whose title matches the input. (optional) 
            var titleStartsWith = titleStartsWith_example;  // string | Return only issues in series whose title starts with the input. (optional) 
            var startYear = 56;  // int? | Return only issues in series whose start year matches the input. (optional) 
            var issueNumber = 56;  // int? | Return only issues in series whose issue number matches the input. (optional) 
            var diamondCode = diamondCode_example;  // string | Filter by diamond code. (optional) 
            var digitalId = 56;  // int? | Filter by digital comic id. (optional) 
            var upc = upc_example;  // string | Filter by UPC. (optional) 
            var isbn = isbn_example;  // string | Filter by ISBN. (optional) 
            var ean = ean_example;  // string | Filter by EAN. (optional) 
            var issn = issn_example;  // string | Filter by ISSN. (optional) 
            var hasDigitalIssue = new List<bool?>(); // List<bool?> | Include only results which are available digitally. (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only comics which have been modified since the specified date. (optional) 
            var creators = new List<int?>(); // List<int?> | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only comics which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only comics which are part of the specified series (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only comics which take place in the specified events (accepts a comma-separated list of ids). (optional) 
            var sharedAppearances = new List<int?>(); // List<int?> | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). (optional) 
            var collaborators = new List<int?>(); // List<int?> | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of comics filtered by a story id.
                apiInstance.GetComicsCollection_3(storyId, format, formatType, noVariants, dateDescriptor, dateRange, title, titleStartsWith, startYear, issueNumber, diamondCode, digitalId, upc, isbn, ean, issn, hasDigitalIssue, modifiedSince, creators, characters, series, events, sharedAppearances, collaborators, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetComicsCollection_3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storyId** | **int?**| The story ID. | 
 **format** | **string**| Filter by the issue format (e.g. comic, digital comic, hardcover). | [optional] 
 **formatType** | **string**| Filter by the issue format type (comic or collection). | [optional] 
 **noVariants** | [**List<bool?>**](bool?.md)| Exclude variant comics from the result set. | [optional] 
 **dateDescriptor** | [**List<string>**](string.md)| Return comics within a predefined date range. | [optional] 
 **dateRange** | [**List<int?>**](int?.md)| Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. | [optional] 
 **title** | **string**| Return only issues in series whose title matches the input. | [optional] 
 **titleStartsWith** | **string**| Return only issues in series whose title starts with the input. | [optional] 
 **startYear** | **int?**| Return only issues in series whose start year matches the input. | [optional] 
 **issueNumber** | **int?**| Return only issues in series whose issue number matches the input. | [optional] 
 **diamondCode** | **string**| Filter by diamond code. | [optional] 
 **digitalId** | **int?**| Filter by digital comic id. | [optional] 
 **upc** | **string**| Filter by UPC. | [optional] 
 **isbn** | **string**| Filter by ISBN. | [optional] 
 **ean** | **string**| Filter by EAN. | [optional] 
 **issn** | **string**| Filter by ISSN. | [optional] 
 **hasDigitalIssue** | [**List<bool?>**](bool?.md)| Include only results which are available digitally. | [optional] 
 **modifiedSince** | **DateTime?**| Return only comics which have been modified since the specified date. | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only comics which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only comics which are part of the specified series (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only comics which take place in the specified events (accepts a comma-separated list of ids). | [optional] 
 **sharedAppearances** | [**List<int?>**](int?.md)| Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). | [optional] 
 **collaborators** | [**List<int?>**](int?.md)| Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreatorcollection"></a>
# **GetCreatorCollection**
> void GetCreatorCollection (string firstName, string middleName, string lastName, string suffix, string nameStartsWith, string firstNameStartsWith, string middleNameStartsWith, string lastNameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<int?> stories, List<string> orderBy, int? limit, int? offset)

Fetches lists of creators.

Fetches lists of comic creators with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetCreatorCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var firstName = firstName_example;  // string | Filter by creator first name (e.g. Brian). (optional) 
            var middleName = middleName_example;  // string | Filter by creator middle name (e.g. Michael). (optional) 
            var lastName = lastName_example;  // string | Filter by creator last name (e.g. Bendis). (optional) 
            var suffix = suffix_example;  // string | Filter by suffix or honorific (e.g. Jr., Sr.). (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Filter by creator names that match critera (e.g. B, St L). (optional) 
            var firstNameStartsWith = firstNameStartsWith_example;  // string | Filter by creator first names that match critera (e.g. B, St L). (optional) 
            var middleNameStartsWith = middleNameStartsWith_example;  // string | Filter by creator middle names that match critera (e.g. Mi). (optional) 
            var lastNameStartsWith = lastNameStartsWith_example;  // string | Filter by creator last names that match critera (e.g. Ben). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only creators which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only creators who worked on the specified series (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of creators.
                apiInstance.GetCreatorCollection(firstName, middleName, lastName, suffix, nameStartsWith, firstNameStartsWith, middleNameStartsWith, lastNameStartsWith, modifiedSince, comics, series, events, stories, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetCreatorCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firstName** | **string**| Filter by creator first name (e.g. Brian). | [optional] 
 **middleName** | **string**| Filter by creator middle name (e.g. Michael). | [optional] 
 **lastName** | **string**| Filter by creator last name (e.g. Bendis). | [optional] 
 **suffix** | **string**| Filter by suffix or honorific (e.g. Jr., Sr.). | [optional] 
 **nameStartsWith** | **string**| Filter by creator names that match critera (e.g. B, St L). | [optional] 
 **firstNameStartsWith** | **string**| Filter by creator first names that match critera (e.g. B, St L). | [optional] 
 **middleNameStartsWith** | **string**| Filter by creator middle names that match critera (e.g. Mi). | [optional] 
 **lastNameStartsWith** | **string**| Filter by creator last names that match critera (e.g. Ben). | [optional] 
 **modifiedSince** | **DateTime?**| Return only creators which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only creators who worked on the specified series (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only creators who worked on the specified stories (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreatorcollection_0"></a>
# **GetCreatorCollection_0**
> void GetCreatorCollection_0 (int? storyId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<string> orderBy, int? limit, int? offset)

Fetches lists of characters filtered by a story id.

Fetches lists of comic characters appearing in a single story, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetCreatorCollection_0Example
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var storyId = 56;  // int? | The story ID.
            var name = name_example;  // string | Return only characters matching the specified full character name (e.g. Spider-Man). (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Return characters with names that begin with the specified string (e.g. Sp). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only characters which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only characters which appear the specified series (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of characters filtered by a story id.
                apiInstance.GetCreatorCollection_0(storyId, name, nameStartsWith, modifiedSince, comics, series, events, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetCreatorCollection_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storyId** | **int?**| The story ID. | 
 **name** | **string**| Return only characters matching the specified full character name (e.g. Spider-Man). | [optional] 
 **nameStartsWith** | **string**| Return characters with names that begin with the specified string (e.g. Sp). | [optional] 
 **modifiedSince** | **DateTime?**| Return only characters which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only characters which appear in the specified comics (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only characters which appear the specified series (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreatorcollection_1"></a>
# **GetCreatorCollection_1**
> void GetCreatorCollection_1 (int? seriesId, string firstName, string middleName, string lastName, string suffix, string nameStartsWith, string firstNameStartsWith, string middleNameStartsWith, string lastNameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> events, List<int?> stories, List<string> orderBy, int? limit, int? offset)

Fetches lists of creators filtered by a series id.

Fetches lists of comic creators whose work appears in a specific series, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetCreatorCollection_1Example
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var seriesId = 56;  // int? | The series ID.
            var firstName = firstName_example;  // string | Filter by creator first name (e.g. brian). (optional) 
            var middleName = middleName_example;  // string | Filter by creator middle name (e.g. Michael). (optional) 
            var lastName = lastName_example;  // string | Filter by creator last name (e.g. Bendis). (optional) 
            var suffix = suffix_example;  // string | Filter by suffix or honorific (e.g. Jr., Sr.). (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Filter by creator names that match critera (e.g. B, St L). (optional) 
            var firstNameStartsWith = firstNameStartsWith_example;  // string | Filter by creator first names that match critera (e.g. B, St L). (optional) 
            var middleNameStartsWith = middleNameStartsWith_example;  // string | Filter by creator middle names that match critera (e.g. Mi). (optional) 
            var lastNameStartsWith = lastNameStartsWith_example;  // string | Filter by creator last names that match critera (e.g. Ben). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only creators which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of creators filtered by a series id.
                apiInstance.GetCreatorCollection_1(seriesId, firstName, middleName, lastName, suffix, nameStartsWith, firstNameStartsWith, middleNameStartsWith, lastNameStartsWith, modifiedSince, comics, events, stories, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetCreatorCollection_1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **seriesId** | **int?**| The series ID. | 
 **firstName** | **string**| Filter by creator first name (e.g. brian). | [optional] 
 **middleName** | **string**| Filter by creator middle name (e.g. Michael). | [optional] 
 **lastName** | **string**| Filter by creator last name (e.g. Bendis). | [optional] 
 **suffix** | **string**| Filter by suffix or honorific (e.g. Jr., Sr.). | [optional] 
 **nameStartsWith** | **string**| Filter by creator names that match critera (e.g. B, St L). | [optional] 
 **firstNameStartsWith** | **string**| Filter by creator first names that match critera (e.g. B, St L). | [optional] 
 **middleNameStartsWith** | **string**| Filter by creator middle names that match critera (e.g. Mi). | [optional] 
 **lastNameStartsWith** | **string**| Filter by creator last names that match critera (e.g. Ben). | [optional] 
 **modifiedSince** | **DateTime?**| Return only creators which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only creators who worked on the specified stories (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreatorcollection_2"></a>
# **GetCreatorCollection_2**
> void GetCreatorCollection_2 (int? comicId, string firstName, string middleName, string lastName, string suffix, string nameStartsWith, string firstNameStartsWith, string middleNameStartsWith, string lastNameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> stories, List<string> orderBy, int? limit, int? offset)

Fetches lists of creators filtered by a comic id.

Fetches lists of comic creators whose work appears in a specific comic, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetCreatorCollection_2Example
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var comicId = 56;  // int? | The comic id.
            var firstName = firstName_example;  // string | Filter by creator first name (e.g. brian). (optional) 
            var middleName = middleName_example;  // string | Filter by creator middle name (e.g. Michael). (optional) 
            var lastName = lastName_example;  // string | Filter by creator last name (e.g. Bendis). (optional) 
            var suffix = suffix_example;  // string | Filter by suffix or honorific (e.g. Jr., Sr.). (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Filter by creator names that match critera (e.g. B, St L). (optional) 
            var firstNameStartsWith = firstNameStartsWith_example;  // string | Filter by creator first names that match critera (e.g. B, St L). (optional) 
            var middleNameStartsWith = middleNameStartsWith_example;  // string | Filter by creator middle names that match critera (e.g. Mi). (optional) 
            var lastNameStartsWith = lastNameStartsWith_example;  // string | Filter by creator last names that match critera (e.g. Ben). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only creators which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only creators who worked on the specified series (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of creators filtered by a comic id.
                apiInstance.GetCreatorCollection_2(comicId, firstName, middleName, lastName, suffix, nameStartsWith, firstNameStartsWith, middleNameStartsWith, lastNameStartsWith, modifiedSince, comics, series, stories, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetCreatorCollection_2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **comicId** | **int?**| The comic id. | 
 **firstName** | **string**| Filter by creator first name (e.g. brian). | [optional] 
 **middleName** | **string**| Filter by creator middle name (e.g. Michael). | [optional] 
 **lastName** | **string**| Filter by creator last name (e.g. Bendis). | [optional] 
 **suffix** | **string**| Filter by suffix or honorific (e.g. Jr., Sr.). | [optional] 
 **nameStartsWith** | **string**| Filter by creator names that match critera (e.g. B, St L). | [optional] 
 **firstNameStartsWith** | **string**| Filter by creator first names that match critera (e.g. B, St L). | [optional] 
 **middleNameStartsWith** | **string**| Filter by creator middle names that match critera (e.g. Mi). | [optional] 
 **lastNameStartsWith** | **string**| Filter by creator last names that match critera (e.g. Ben). | [optional] 
 **modifiedSince** | **DateTime?**| Return only creators which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only creators who worked on the specified series (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only creators who worked on the specified stories (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreatorcollection_3"></a>
# **GetCreatorCollection_3**
> void GetCreatorCollection_3 (string name, string nameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<int?> stories, List<string> orderBy, int? limit, int? offset)

Fetches lists of characters.

Fetches lists of comic characters with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetCreatorCollection_3Example
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var name = name_example;  // string | Return only characters matching the specified full character name (e.g. Spider-Man). (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Return characters with names that begin with the specified string (e.g. Sp). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only characters which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only characters which appear the specified series (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only characters which appear in the specified events (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only characters which appear the specified stories (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of characters.
                apiInstance.GetCreatorCollection_3(name, nameStartsWith, modifiedSince, comics, series, events, stories, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetCreatorCollection_3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Return only characters matching the specified full character name (e.g. Spider-Man). | [optional] 
 **nameStartsWith** | **string**| Return characters with names that begin with the specified string (e.g. Sp). | [optional] 
 **modifiedSince** | **DateTime?**| Return only characters which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only characters which appear in the specified comics (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only characters which appear the specified series (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only characters which appear in the specified events (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only characters which appear the specified stories (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreatorcollection_4"></a>
# **GetCreatorCollection_4**
> void GetCreatorCollection_4 (int? storyId, string firstName, string middleName, string lastName, string suffix, string nameStartsWith, string firstNameStartsWith, string middleNameStartsWith, string lastNameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<string> orderBy, int? limit, int? offset)

Fetches lists of creators filtered by a story id.

Fetches lists of comic creators whose work appears in a specific story, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetCreatorCollection_4Example
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var storyId = 56;  // int? | The story ID.
            var firstName = firstName_example;  // string | Filter by creator first name (e.g. brian). (optional) 
            var middleName = middleName_example;  // string | Filter by creator middle name (e.g. Michael). (optional) 
            var lastName = lastName_example;  // string | Filter by creator last name (e.g. Bendis). (optional) 
            var suffix = suffix_example;  // string | Filter by suffix or honorific (e.g. Jr., Sr.). (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Filter by creator names that match critera (e.g. B, St L). (optional) 
            var firstNameStartsWith = firstNameStartsWith_example;  // string | Filter by creator first names that match critera (e.g. B, St L). (optional) 
            var middleNameStartsWith = middleNameStartsWith_example;  // string | Filter by creator middle names that match critera (e.g. Mi). (optional) 
            var lastNameStartsWith = lastNameStartsWith_example;  // string | Filter by creator last names that match critera (e.g. Ben). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only creators which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only creators who worked on the specified series (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of creators filtered by a story id.
                apiInstance.GetCreatorCollection_4(storyId, firstName, middleName, lastName, suffix, nameStartsWith, firstNameStartsWith, middleNameStartsWith, lastNameStartsWith, modifiedSince, comics, series, events, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetCreatorCollection_4: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storyId** | **int?**| The story ID. | 
 **firstName** | **string**| Filter by creator first name (e.g. brian). | [optional] 
 **middleName** | **string**| Filter by creator middle name (e.g. Michael). | [optional] 
 **lastName** | **string**| Filter by creator last name (e.g. Bendis). | [optional] 
 **suffix** | **string**| Filter by suffix or honorific (e.g. Jr., Sr.). | [optional] 
 **nameStartsWith** | **string**| Filter by creator names that match critera (e.g. B, St L). | [optional] 
 **firstNameStartsWith** | **string**| Filter by creator first names that match critera (e.g. B, St L). | [optional] 
 **middleNameStartsWith** | **string**| Filter by creator middle names that match critera (e.g. Mi). | [optional] 
 **lastNameStartsWith** | **string**| Filter by creator last names that match critera (e.g. Ben). | [optional] 
 **modifiedSince** | **DateTime?**| Return only creators which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only creators who worked on the specified series (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreatorcollection_5"></a>
# **GetCreatorCollection_5**
> void GetCreatorCollection_5 (int? eventId, string firstName, string middleName, string lastName, string suffix, string nameStartsWith, string firstNameStartsWith, string middleNameStartsWith, string lastNameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> stories, List<string> orderBy, int? limit, int? offset)

Fetches lists of creators filtered by an event id.

Fetches lists of comic creators whose work appears in a specific event, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetCreatorCollection_5Example
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var eventId = 56;  // int? | The event ID.
            var firstName = firstName_example;  // string | Filter by creator first name (e.g. brian). (optional) 
            var middleName = middleName_example;  // string | Filter by creator middle name (e.g. Michael). (optional) 
            var lastName = lastName_example;  // string | Filter by creator last name (e.g. Bendis). (optional) 
            var suffix = suffix_example;  // string | Filter by suffix or honorific (e.g. Jr., Sr.). (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Filter by creator names that match critera (e.g. B, St L). (optional) 
            var firstNameStartsWith = firstNameStartsWith_example;  // string | Filter by creator first names that match critera (e.g. B, St L). (optional) 
            var middleNameStartsWith = middleNameStartsWith_example;  // string | Filter by creator middle names that match critera (e.g. Mi). (optional) 
            var lastNameStartsWith = lastNameStartsWith_example;  // string | Filter by creator last names that match critera (e.g. Ben). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only creators which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only creators who worked on the specified series (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of creators filtered by an event id.
                apiInstance.GetCreatorCollection_5(eventId, firstName, middleName, lastName, suffix, nameStartsWith, firstNameStartsWith, middleNameStartsWith, lastNameStartsWith, modifiedSince, comics, series, stories, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetCreatorCollection_5: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **int?**| The event ID. | 
 **firstName** | **string**| Filter by creator first name (e.g. brian). | [optional] 
 **middleName** | **string**| Filter by creator middle name (e.g. Michael). | [optional] 
 **lastName** | **string**| Filter by creator last name (e.g. Bendis). | [optional] 
 **suffix** | **string**| Filter by suffix or honorific (e.g. Jr., Sr.). | [optional] 
 **nameStartsWith** | **string**| Filter by creator names that match critera (e.g. B, St L). | [optional] 
 **firstNameStartsWith** | **string**| Filter by creator first names that match critera (e.g. B, St L). | [optional] 
 **middleNameStartsWith** | **string**| Filter by creator middle names that match critera (e.g. Mi). | [optional] 
 **lastNameStartsWith** | **string**| Filter by creator last names that match critera (e.g. Ben). | [optional] 
 **modifiedSince** | **DateTime?**| Return only creators which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only creators who worked on the specified series (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only creators who worked on the specified stories (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreatoreventscollection"></a>
# **GetCreatorEventsCollection**
> void GetCreatorEventsCollection (int? creatorId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> characters, List<int?> series, List<int?> comics, List<int?> stories, List<string> orderBy, int? limit, int? offset)

Fetches lists of events filtered by a creator id.

Fetches lists of events featuring the work of a specific creator with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetCreatorEventsCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var creatorId = 56;  // int? | The creator ID.
            var name = name_example;  // string | Filter the event list by name. (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Return events with names that begin with the specified string (e.g. Sp). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only events which have been modified since the specified date. (optional) 
            var characters = new List<int?>(); // List<int?> | Return only events which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only events which are part of the specified series (accepts a comma-separated list of ids). (optional) 
            var comics = new List<int?>(); // List<int?> | Return only events which take place in the specified comics (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only events which contain the specified stories (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of events filtered by a creator id.
                apiInstance.GetCreatorEventsCollection(creatorId, name, nameStartsWith, modifiedSince, characters, series, comics, stories, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetCreatorEventsCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **creatorId** | **int?**| The creator ID. | 
 **name** | **string**| Filter the event list by name. | [optional] 
 **nameStartsWith** | **string**| Return events with names that begin with the specified string (e.g. Sp). | [optional] 
 **modifiedSince** | **DateTime?**| Return only events which have been modified since the specified date. | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only events which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only events which are part of the specified series (accepts a comma-separated list of ids). | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only events which take place in the specified comics (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only events which contain the specified stories (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreatorindividual"></a>
# **GetCreatorIndividual**
> void GetCreatorIndividual (int? creatorId)

Fetches a single creator by id.

This method fetches a single creator resource.  It is the canonical URI for any creator resource provided by the API.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetCreatorIndividualExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var creatorId = 56;  // int? | A single creator id.

            try
            {
                // Fetches a single creator by id.
                apiInstance.GetCreatorIndividual(creatorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetCreatorIndividual: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **creatorId** | **int?**| A single creator id. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreatorseriescollection"></a>
# **GetCreatorSeriesCollection**
> void GetCreatorSeriesCollection (int? creatorId, string title, string titleStartsWith, int? startYear, DateTime? modifiedSince, List<int?> comics, List<int?> stories, List<int?> events, List<int?> characters, string seriesType, List<string> contains, List<string> orderBy, int? limit, int? offset)

Fetches lists of series filtered by a creator id.

Fetches lists of comic series in which a specific creator's work appears, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetCreatorSeriesCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var creatorId = 56;  // int? | The creator ID.
            var title = title_example;  // string | Filter by series title. (optional) 
            var titleStartsWith = titleStartsWith_example;  // string | Return series with titles that begin with the specified string (e.g. Sp). (optional) 
            var startYear = 56;  // int? | Return only series matching the specified start year. (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only series which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only series which contain the specified comics (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only series which contain the specified stories (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only series which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var seriesType = seriesType_example;  // string | Filter the series by publication frequency type. (optional) 
            var contains = new List<string>(); // List<string> | Return only series containing one or more comics with the specified format. (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of series filtered by a creator id.
                apiInstance.GetCreatorSeriesCollection(creatorId, title, titleStartsWith, startYear, modifiedSince, comics, stories, events, characters, seriesType, contains, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetCreatorSeriesCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **creatorId** | **int?**| The creator ID. | 
 **title** | **string**| Filter by series title. | [optional] 
 **titleStartsWith** | **string**| Return series with titles that begin with the specified string (e.g. Sp). | [optional] 
 **startYear** | **int?**| Return only series matching the specified start year. | [optional] 
 **modifiedSince** | **DateTime?**| Return only series which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only series which contain the specified comics (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only series which contain the specified stories (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only series which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **seriesType** | **string**| Filter the series by publication frequency type. | [optional] 
 **contains** | [**List<string>**](string.md)| Return only series containing one or more comics with the specified format. | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreatorstorycollection"></a>
# **GetCreatorStoryCollection**
> void GetCreatorStoryCollection (int? creatorId, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<int?> characters, List<string> orderBy, int? limit, int? offset)

Fetches lists of stories filtered by a creator id.

Fetches lists of comic stories by a specific creator with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetCreatorStoryCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var creatorId = 56;  // int? | The ID of the creator.
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only stories which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only stories contained in the specified comics (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only stories contained the specified series (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only stories which take place during the specified events (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only stories which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of stories filtered by a creator id.
                apiInstance.GetCreatorStoryCollection(creatorId, modifiedSince, comics, series, events, characters, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetCreatorStoryCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **creatorId** | **int?**| The ID of the creator. | 
 **modifiedSince** | **DateTime?**| Return only stories which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only stories contained in the specified comics (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only stories contained the specified series (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only stories which take place during the specified events (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only stories which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventcharactercollection"></a>
# **GetEventCharacterCollection**
> void GetEventCharacterCollection (int? eventId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> stories, List<string> orderBy, int? limit, int? offset)

Fetches lists of characters filtered by an event id.

Fetches lists of characters which appear in a specific event, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetEventCharacterCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var eventId = 56;  // int? | The event ID
            var name = name_example;  // string | Return only characters matching the specified full character name (e.g. Spider-Man). (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Return characters with names that begin with the specified string (e.g. Sp). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only characters which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only characters which appear the specified series (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only characters which appear the specified stories (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of characters filtered by an event id.
                apiInstance.GetEventCharacterCollection(eventId, name, nameStartsWith, modifiedSince, comics, series, stories, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetEventCharacterCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **int?**| The event ID | 
 **name** | **string**| Return only characters matching the specified full character name (e.g. Spider-Man). | [optional] 
 **nameStartsWith** | **string**| Return characters with names that begin with the specified string (e.g. Sp). | [optional] 
 **modifiedSince** | **DateTime?**| Return only characters which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only characters which appear in the specified comics (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only characters which appear the specified series (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only characters which appear the specified stories (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventindividual"></a>
# **GetEventIndividual**
> void GetEventIndividual (int? eventId)

Fetches a single event by id.

This method fetches a single event resource.  It is the canonical URI for any event resource provided by the API.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetEventIndividualExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var eventId = 56;  // int? | A single event.

            try
            {
                // Fetches a single event by id.
                apiInstance.GetEventIndividual(eventId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetEventIndividual: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **int?**| A single event. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventseriescollection"></a>
# **GetEventSeriesCollection**
> void GetEventSeriesCollection (int? eventId, string title, string titleStartsWith, int? startYear, DateTime? modifiedSince, List<int?> comics, List<int?> stories, List<int?> creators, List<int?> characters, string seriesType, List<string> contains, List<string> orderBy, int? limit, int? offset)

Fetches lists of series filtered by an event id.

Fetches lists of comic series in which a specific event takes place, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetEventSeriesCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var eventId = 56;  // int? | The event ID.
            var title = title_example;  // string | Filter by series title. (optional) 
            var titleStartsWith = titleStartsWith_example;  // string | Return series with titles that begin with the specified string (e.g. Sp). (optional) 
            var startYear = 56;  // int? | Return only series matching the specified start year. (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only series which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only series which contain the specified comics (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only series which contain the specified stories (accepts a comma-separated list of ids). (optional) 
            var creators = new List<int?>(); // List<int?> | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only series which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var seriesType = seriesType_example;  // string | Filter the series by publication frequency type. (optional) 
            var contains = new List<string>(); // List<string> | Return only series containing one or more comics with the specified format. (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of series filtered by an event id.
                apiInstance.GetEventSeriesCollection(eventId, title, titleStartsWith, startYear, modifiedSince, comics, stories, creators, characters, seriesType, contains, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetEventSeriesCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **int?**| The event ID. | 
 **title** | **string**| Filter by series title. | [optional] 
 **titleStartsWith** | **string**| Return series with titles that begin with the specified string (e.g. Sp). | [optional] 
 **startYear** | **int?**| Return only series matching the specified start year. | [optional] 
 **modifiedSince** | **DateTime?**| Return only series which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only series which contain the specified comics (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only series which contain the specified stories (accepts a comma-separated list of ids). | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only series which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only series which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **seriesType** | **string**| Filter the series by publication frequency type. | [optional] 
 **contains** | [**List<string>**](string.md)| Return only series containing one or more comics with the specified format. | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventstorycollection"></a>
# **GetEventStoryCollection**
> void GetEventStoryCollection (int? eventId, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> creators, List<int?> characters, List<string> orderBy, int? limit, int? offset)

Fetches lists of stories filtered by an event id.

Fetches lists of comic stories from a specific event, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetEventStoryCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var eventId = 56;  // int? | The ID of the event.
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only stories which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only stories contained in the specified (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only stories contained the specified series (accepts a comma-separated list of ids). (optional) 
            var creators = new List<int?>(); // List<int?> | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only stories which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of stories filtered by an event id.
                apiInstance.GetEventStoryCollection(eventId, modifiedSince, comics, series, creators, characters, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetEventStoryCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **int?**| The ID of the event. | 
 **modifiedSince** | **DateTime?**| Return only stories which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only stories contained in the specified (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only stories contained the specified series (accepts a comma-separated list of ids). | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only stories which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventscollection"></a>
# **GetEventsCollection**
> void GetEventsCollection (int? storyId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> comics, List<string> orderBy, int? limit, int? offset)

Fetches lists of events filtered by a story id.

Fetches lists of events in which a specific story appears, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetEventsCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var storyId = 56;  // int? | The story ID.
            var name = name_example;  // string | Filter the event list by name. (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Return events with names that begin with the specified string (e.g. Sp). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only events which have been modified since the specified date. (optional) 
            var creators = new List<int?>(); // List<int?> | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only events which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only events which are part of the specified series (accepts a comma-separated list of ids). (optional) 
            var comics = new List<int?>(); // List<int?> | Return only events which take place in the specified comics (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of events filtered by a story id.
                apiInstance.GetEventsCollection(storyId, name, nameStartsWith, modifiedSince, creators, characters, series, comics, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetEventsCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storyId** | **int?**| The story ID. | 
 **name** | **string**| Filter the event list by name. | [optional] 
 **nameStartsWith** | **string**| Return events with names that begin with the specified string (e.g. Sp). | [optional] 
 **modifiedSince** | **DateTime?**| Return only events which have been modified since the specified date. | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only events which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only events which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only events which are part of the specified series (accepts a comma-separated list of ids). | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only events which take place in the specified comics (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventscollection_0"></a>
# **GetEventsCollection_0**
> void GetEventsCollection_0 (int? seriesId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> comics, List<int?> stories, List<string> orderBy, int? limit, int? offset)

Fetches lists of events filtered by a series id.

Fetches lists of events which occur in a specific series, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetEventsCollection_0Example
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var seriesId = 56;  // int? | The series ID.
            var name = name_example;  // string | Filter the event list by name. (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Return events with names that begin with the specified string (e.g. Sp). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only events which have been modified since the specified date. (optional) 
            var creators = new List<int?>(); // List<int?> | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only events which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var comics = new List<int?>(); // List<int?> | Return only events which take place in the specified comics (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only events which contain the specified stories (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of events filtered by a series id.
                apiInstance.GetEventsCollection_0(seriesId, name, nameStartsWith, modifiedSince, creators, characters, comics, stories, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetEventsCollection_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **seriesId** | **int?**| The series ID. | 
 **name** | **string**| Filter the event list by name. | [optional] 
 **nameStartsWith** | **string**| Return events with names that begin with the specified string (e.g. Sp). | [optional] 
 **modifiedSince** | **DateTime?**| Return only events which have been modified since the specified date. | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only events which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only events which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only events which take place in the specified comics (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only events which contain the specified stories (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventscollection_1"></a>
# **GetEventsCollection_1**
> void GetEventsCollection_1 (string name, string nameStartsWith, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> comics, List<int?> stories, List<string> orderBy, int? limit, int? offset)

Fetches lists of events.

Fetches lists of events with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetEventsCollection_1Example
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var name = name_example;  // string | Return only events which match the specified name. (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Return events with names that begin with the specified string (e.g. Sp). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only events which have been modified since the specified date. (optional) 
            var creators = new List<int?>(); // List<int?> | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only events which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only events which are part of the specified series (accepts a comma-separated list of ids). (optional) 
            var comics = new List<int?>(); // List<int?> | Return only events which take place in the specified comics (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only events which take place in the specified stories (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of events.
                apiInstance.GetEventsCollection_1(name, nameStartsWith, modifiedSince, creators, characters, series, comics, stories, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetEventsCollection_1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Return only events which match the specified name. | [optional] 
 **nameStartsWith** | **string**| Return events with names that begin with the specified string (e.g. Sp). | [optional] 
 **modifiedSince** | **DateTime?**| Return only events which have been modified since the specified date. | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only events which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only events which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only events which are part of the specified series (accepts a comma-separated list of ids). | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only events which take place in the specified comics (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only events which take place in the specified stories (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getissueeventscollection"></a>
# **GetIssueEventsCollection**
> void GetIssueEventsCollection (int? comicId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> stories, List<string> orderBy, int? limit, int? offset)

Fetches lists of events filtered by a comic id.

Fetches lists of events in which a specific comic appears, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetIssueEventsCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var comicId = 56;  // int? | The comic ID.
            var name = name_example;  // string | Filter the event list by name. (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Return events with names that begin with the specified string (e.g. Sp). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only events which have been modified since the specified date. (optional) 
            var creators = new List<int?>(); // List<int?> | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only events which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only events which are part of the specified series (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only events which contain the specified stories (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of events filtered by a comic id.
                apiInstance.GetIssueEventsCollection(comicId, name, nameStartsWith, modifiedSince, creators, characters, series, stories, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetIssueEventsCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **comicId** | **int?**| The comic ID. | 
 **name** | **string**| Filter the event list by name. | [optional] 
 **nameStartsWith** | **string**| Return events with names that begin with the specified string (e.g. Sp). | [optional] 
 **modifiedSince** | **DateTime?**| Return only events which have been modified since the specified date. | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only events which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only events which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only events which are part of the specified series (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only events which contain the specified stories (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getseriescharacterwrapper"></a>
# **GetSeriesCharacterWrapper**
> void GetSeriesCharacterWrapper (int? seriesId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> events, List<int?> stories, List<string> orderBy, int? limit, int? offset)

Fetches lists of characters filtered by a series id.

Fetches lists of characters which appear in specific series, with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetSeriesCharacterWrapperExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var seriesId = 56;  // int? | The series id.
            var name = name_example;  // string | Return only characters matching the specified full character name (e.g. Spider-Man). (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Return characters with names that begin with the specified string (e.g. Sp). (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only characters which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only characters which appear the specified stories (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of characters filtered by a series id.
                apiInstance.GetSeriesCharacterWrapper(seriesId, name, nameStartsWith, modifiedSince, comics, events, stories, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetSeriesCharacterWrapper: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **seriesId** | **int?**| The series id. | 
 **name** | **string**| Return only characters matching the specified full character name (e.g. Spider-Man). | [optional] 
 **nameStartsWith** | **string**| Return characters with names that begin with the specified string (e.g. Sp). | [optional] 
 **modifiedSince** | **DateTime?**| Return only characters which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only characters which appear in the specified comics (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only characters which appear the specified stories (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getseriescollection"></a>
# **GetSeriesCollection**
> void GetSeriesCollection (string title, string titleStartsWith, int? startYear, DateTime? modifiedSince, List<int?> comics, List<int?> stories, List<int?> events, List<int?> creators, List<int?> characters, string seriesType, List<string> contains, List<string> orderBy, int? limit, int? offset)

Fetches lists of series.

Fetches lists of comic series with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetSeriesCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var title = title_example;  // string | Return only series matching the specified title. (optional) 
            var titleStartsWith = titleStartsWith_example;  // string | Return series with titles that begin with the specified string (e.g. Sp). (optional) 
            var startYear = 56;  // int? | Return only series matching the specified start year. (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only series which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only series which contain the specified comics (accepts a comma-separated list of ids). (optional) 
            var stories = new List<int?>(); // List<int?> | Return only series which contain the specified stories (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). (optional) 
            var creators = new List<int?>(); // List<int?> | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only series which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var seriesType = seriesType_example;  // string | Filter the series by publication frequency type. (optional) 
            var contains = new List<string>(); // List<string> | Return only series containing one or more comics with the specified format. (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of series.
                apiInstance.GetSeriesCollection(title, titleStartsWith, startYear, modifiedSince, comics, stories, events, creators, characters, seriesType, contains, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetSeriesCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **title** | **string**| Return only series matching the specified title. | [optional] 
 **titleStartsWith** | **string**| Return series with titles that begin with the specified string (e.g. Sp). | [optional] 
 **startYear** | **int?**| Return only series matching the specified start year. | [optional] 
 **modifiedSince** | **DateTime?**| Return only series which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only series which contain the specified comics (accepts a comma-separated list of ids). | [optional] 
 **stories** | [**List<int?>**](int?.md)| Return only series which contain the specified stories (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only series which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only series which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **seriesType** | **string**| Filter the series by publication frequency type. | [optional] 
 **contains** | [**List<string>**](string.md)| Return only series containing one or more comics with the specified format. | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getseriesindividual"></a>
# **GetSeriesIndividual**
> void GetSeriesIndividual (int? seriesId)

Fetches a single comic series by id.

This method fetches a single comic series resource.  It is the canonical URI for any comic series resource provided by the API.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetSeriesIndividualExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var seriesId = 56;  // int? | Filter by series title.

            try
            {
                // Fetches a single comic series by id.
                apiInstance.GetSeriesIndividual(seriesId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetSeriesIndividual: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **seriesId** | **int?**| Filter by series title. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getseriesstorycollection"></a>
# **GetSeriesStoryCollection**
> void GetSeriesStoryCollection (int? seriesId, DateTime? modifiedSince, List<int?> comics, List<int?> events, List<int?> creators, List<int?> characters, List<string> orderBy, int? limit, int? offset)

Fetches lists of stories filtered by a series id.

Fetches lists of comic stories from a specific series with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetSeriesStoryCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var seriesId = 56;  // int? | The series ID.
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only stories which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only stories contained in the specified (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only stories which take place during the specified events (accepts a comma-separated list of ids). (optional) 
            var creators = new List<int?>(); // List<int?> | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only stories which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of stories filtered by a series id.
                apiInstance.GetSeriesStoryCollection(seriesId, modifiedSince, comics, events, creators, characters, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetSeriesStoryCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **seriesId** | **int?**| The series ID. | 
 **modifiedSince** | **DateTime?**| Return only stories which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only stories contained in the specified (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only stories which take place during the specified events (accepts a comma-separated list of ids). | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only stories which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorycollection"></a>
# **GetStoryCollection**
> void GetStoryCollection (DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<int?> creators, List<int?> characters, List<string> orderBy, int? limit, int? offset)

Fetches lists of stories.

Fetches lists of comic stories with optional filters. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetStoryCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only stories which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only stories contained in the specified (accepts a comma-separated list of ids). (optional) 
            var series = new List<int?>(); // List<int?> | Return only stories contained the specified series (accepts a comma-separated list of ids). (optional) 
            var events = new List<int?>(); // List<int?> | Return only stories which take place during the specified events (accepts a comma-separated list of ids). (optional) 
            var creators = new List<int?>(); // List<int?> | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only stories which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of stories.
                apiInstance.GetStoryCollection(modifiedSince, comics, series, events, creators, characters, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetStoryCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **modifiedSince** | **DateTime?**| Return only stories which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only stories contained in the specified (accepts a comma-separated list of ids). | [optional] 
 **series** | [**List<int?>**](int?.md)| Return only stories contained the specified series (accepts a comma-separated list of ids). | [optional] 
 **events** | [**List<int?>**](int?.md)| Return only stories which take place during the specified events (accepts a comma-separated list of ids). | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only stories which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoryindividual"></a>
# **GetStoryIndividual**
> void GetStoryIndividual (int? storyId)

Fetches a single comic story by id.

This method fetches a single comic story resource.  It is the canonical URI for any comic story resource provided by the API.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetStoryIndividualExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var storyId = 56;  // int? | Filter by story id.

            try
            {
                // Fetches a single comic story by id.
                apiInstance.GetStoryIndividual(storyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetStoryIndividual: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storyId** | **int?**| Filter by story id. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoryseriescollection"></a>
# **GetStorySeriesCollection**
> void GetStorySeriesCollection (int? storyId, List<int?> events, string title, string titleStartsWith, int? startYear, DateTime? modifiedSince, List<int?> comics, List<int?> creators, List<int?> characters, string seriesType, List<string> contains, List<string> orderBy, int? limit, int? offset)

Fetches lists of series filtered by a story id.

Fetches lists of comic series in which the specified story takes place. See notes on individual parameters below.

### Example
```csharp
using System;
using System.Diagnostics;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.SDK.Model;

namespace Example
{
    public class GetStorySeriesCollectionExample
    {
        public void main()
        {

            var apiInstance = new DocspublicApi();
            var storyId = 56;  // int? | The story ID.
            var events = new List<int?>(); // List<int?> | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). (optional) 
            var title = title_example;  // string | Filter by series title. (optional) 
            var titleStartsWith = titleStartsWith_example;  // string | Return series with titles that begin with the specified string (e.g. Sp). (optional) 
            var startYear = 56;  // int? | Return only series matching the specified start year. (optional) 
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Return only series which have been modified since the specified date. (optional) 
            var comics = new List<int?>(); // List<int?> | Return only series which contain the specified comics (accepts a comma-separated list of ids). (optional) 
            var creators = new List<int?>(); // List<int?> | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). (optional) 
            var characters = new List<int?>(); // List<int?> | Return only series which feature the specified characters (accepts a comma-separated list of ids). (optional) 
            var seriesType = seriesType_example;  // string | Filter the series by publication frequency type. (optional) 
            var contains = new List<string>(); // List<string> | Return only series containing one or more comics with the specified format. (optional) 
            var orderBy = new List<string>(); // List<string> | Order the result set by a field or fields. Add a \"-\" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (optional) 
            var limit = 56;  // int? | Limit the result set to the specified number of resources. (optional) 
            var offset = 56;  // int? | Skip the specified number of resources in the result set. (optional) 

            try
            {
                // Fetches lists of series filtered by a story id.
                apiInstance.GetStorySeriesCollection(storyId, events, title, titleStartsWith, startYear, modifiedSince, comics, creators, characters, seriesType, contains, orderBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocspublicApi.GetStorySeriesCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storyId** | **int?**| The story ID. | 
 **events** | [**List<int?>**](int?.md)| Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). | [optional] 
 **title** | **string**| Filter by series title. | [optional] 
 **titleStartsWith** | **string**| Return series with titles that begin with the specified string (e.g. Sp). | [optional] 
 **startYear** | **int?**| Return only series matching the specified start year. | [optional] 
 **modifiedSince** | **DateTime?**| Return only series which have been modified since the specified date. | [optional] 
 **comics** | [**List<int?>**](int?.md)| Return only series which contain the specified comics (accepts a comma-separated list of ids). | [optional] 
 **creators** | [**List<int?>**](int?.md)| Return only series which feature work by the specified creators (accepts a comma-separated list of ids). | [optional] 
 **characters** | [**List<int?>**](int?.md)| Return only series which feature the specified characters (accepts a comma-separated list of ids). | [optional] 
 **seriesType** | **string**| Filter the series by publication frequency type. | [optional] 
 **contains** | [**List<string>**](string.md)| Return only series containing one or more comics with the specified format. | [optional] 
 **orderBy** | [**List<string>**](string.md)| Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed. | [optional] 
 **limit** | **int?**| Limit the result set to the specified number of resources. | [optional] 
 **offset** | **int?**| Skip the specified number of resources in the result set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


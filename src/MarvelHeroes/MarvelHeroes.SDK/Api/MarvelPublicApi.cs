using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MarvelHeroes.SDK.Client;
using RestSharp; 

namespace MarvelHeroes.SDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMarvelPublicApi
    {
        /// <summary>
        /// Fetches lists of events filtered by a character id. Fetches lists of events in which a specific character appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="characterId">The character ID.</param>
        /// <param name="name">Filter the event list by name.</param>
        /// <param name="nameStartsWith">Return events with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only events which have been modified since the specified date.</param>
        /// <param name="creators">Return only events which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only events which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="comics">Return only events which take place in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only events which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetCharacterEventsCollection (int? characterId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> creators, List<int?> series, List<int?> comics, List<int?> stories, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches a single character by id. This method fetches a single character resource.  It is the canonical URI for any character resource provided by the API.
        /// </summary>
        /// <param name="characterId">A single character id.</param>
        /// <returns></returns>
        IRestResponse GetCharacterIndividual (int? characterId);
        /// <summary>
        /// Fetches lists of series filtered by a character id. Fetches lists of comic series in which a specific character appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="characterId">The character ID</param>
        /// <param name="title">Filter by series title.</param>
        /// <param name="titleStartsWith">Return series with titles that begin with the specified string (e.g. Sp).</param>
        /// <param name="startYear">Return only series matching the specified start year.</param>
        /// <param name="modifiedSince">Return only series which have been modified since the specified date.</param>
        /// <param name="comics">Return only series which contain the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only series which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only series which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="seriesType">Filter the series by publication frequency type.</param>
        /// <param name="contains">Return only series containing one or more comics with the specified format.</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetCharacterSeriesCollection (int? characterId, string title, string titleStartsWith, int? startYear, DateTime? modifiedSince, List<int?> comics, List<int?> stories, List<int?> events, List<int?> creators, string seriesType, List<string> contains, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of stories filtered by a character id. Fetches lists of comic stories  featuring a specific character with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="characterId">The character ID.</param>
        /// <param name="modifiedSince">Return only stories which have been modified since the specified date.</param>
        /// <param name="comics">Return only stories contained in the specified (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only stories contained the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only stories which take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only stories which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetCharacterStoryCollection (int? characterId, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<int?> creators, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of characters filtered by a comic id. Fetches lists of characters which appear in a specific comic with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="comicId">The comic id.</param>
        /// <param name="name">Return only characters matching the specified full character name (e.g. Spider-Man).</param>
        /// <param name="nameStartsWith">Return characters with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only characters which have been modified since the specified date.</param>
        /// <param name="series">Return only characters which appear the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only characters which appear the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetComicCharacterCollection (int? comicId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> series, List<int?> events, List<int?> stories, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches a single comic by id. This method fetches a single comic resource.  It is the canonical URI for any comic resource provided by the API.
        /// </summary>
        /// <param name="comicId">A single comic.</param>
        /// <returns></returns>
        IRestResponse GetComicIndividual (int? comicId);
        /// <summary>
        /// Fetches lists of stories filtered by a comic id. Fetches lists of comic stories in a specific comic issue, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="comicId">The comic ID.</param>
        /// <param name="modifiedSince">Return only stories which have been modified since the specified date.</param>
        /// <param name="series">Return only stories contained the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only stories which take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only stories which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only stories which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources.</param>
        /// <returns></returns>
        IRestResponse GetComicStoryCollection (int? comicId, DateTime? modifiedSince, List<int?> series, List<int?> events, List<int?> creators, List<int?> characters, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of comics filtered by a character id. Fetches lists of comics containing a specific character, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="characterId">The character id.</param>
        /// <param name="format">Filter by the issue format (e.g. comic, digital comic, hardcover).</param>
        /// <param name="formatType">Filter by the issue format type (comic or collection).</param>
        /// <param name="noVariants">Exclude variant comics from the result set.</param>
        /// <param name="dateDescriptor">Return comics within a predefined date range.</param>
        /// <param name="dateRange">Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format.</param>
        /// <param name="title">Return only issues in series whose title matches the input.</param>
        /// <param name="titleStartsWith">Return only issues in series whose title starts with the input.</param>
        /// <param name="startYear">Return only issues in series whose start year matches the input.</param>
        /// <param name="issueNumber">Return only issues in series whose issue number matches the input.</param>
        /// <param name="diamondCode">Filter by diamond code.</param>
        /// <param name="digitalId">Filter by digital comic id.</param>
        /// <param name="upc">Filter by UPC.</param>
        /// <param name="isbn">Filter by ISBN.</param>
        /// <param name="ean">Filter by EAN.</param>
        /// <param name="issn">Filter by ISSN.</param>
        /// <param name="hasDigitalIssue">Include only results which are available digitally.</param>
        /// <param name="modifiedSince">Return only comics which have been modified since the specified date.</param>
        /// <param name="creators">Return only comics which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only comics which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only comics which take place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only comics which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="sharedAppearances">Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear).</param>
        /// <param name="collaborators">Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetComicsCharacterCollection (int? characterId, string format, string formatType, bool? noVariants, string dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, bool? hasDigitalIssue, DateTime? modifiedSince, List<int?> creators, List<int?> series, List<int?> events, List<int?> stories, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of comics filtered by a creator id. Fetches lists of comics in which the work of a specific creator appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="creatorId">The creator ID.</param>
        /// <param name="format">Filter by the issue format (e.g. comic, digital comic, hardcover).</param>
        /// <param name="formatType">Filter by the issue format type (comic or collection).</param>
        /// <param name="noVariants">Exclude variant comics from the result set.</param>
        /// <param name="dateDescriptor">Return comics within a predefined date range.</param>
        /// <param name="dateRange">Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format.</param>
        /// <param name="title">Return only issues in series whose title matches the input.</param>
        /// <param name="titleStartsWith">Return only issues in series whose title starts with the input.</param>
        /// <param name="startYear">Return only issues in series whose start year matches the input.</param>
        /// <param name="issueNumber">Return only issues in series whose issue number matches the input.</param>
        /// <param name="diamondCode">Filter by diamond code.</param>
        /// <param name="digitalId">Filter by digital comic id.</param>
        /// <param name="upc">Filter by UPC.</param>
        /// <param name="isbn">Filter by ISBN.</param>
        /// <param name="ean">Filter by EAN.</param>
        /// <param name="issn">Filter by ISSN.</param>
        /// <param name="hasDigitalIssue">Include only results which are available digitally.</param>
        /// <param name="modifiedSince">Return only comics which have been modified since the specified date.</param>
        /// <param name="characters">Return only comics which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only comics which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only comics which take place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only comics which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="sharedAppearances">Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear).</param>
        /// <param name="collaborators">Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetComicsCollection (int? creatorId, string format, string formatType, bool? noVariants, string dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, List<bool?> hasDigitalIssue, DateTime? modifiedSince, List<int?> characters, List<int?> series, List<int?> events, List<int?> stories, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of comics filtered by an event id. Fetches lists of comics which take place during a specific event, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="eventId">The event id.</param>
        /// <param name="format">Filter by the issue format (e.g. comic, digital comic, hardcover).</param>
        /// <param name="formatType">Filter by the issue format type (comic or collection).</param>
        /// <param name="noVariants">Exclude variant comics from the result set.</param>
        /// <param name="dateDescriptor">Return comics within a predefined date range.</param>
        /// <param name="dateRange">Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format.</param>
        /// <param name="title">Return only issues in series whose title matches the input.</param>
        /// <param name="titleStartsWith">Return only issues in series whose title starts with the input.</param>
        /// <param name="startYear">Return only issues in series whose start year matches the input.</param>
        /// <param name="issueNumber">Return only issues in series whose issue number matches the input.</param>
        /// <param name="diamondCode">Filter by diamond code.</param>
        /// <param name="digitalId">Filter by digital comic id.</param>
        /// <param name="upc">Filter by UPC.</param>
        /// <param name="isbn">Filter by ISBN.</param>
        /// <param name="ean">Filter by EAN.</param>
        /// <param name="issn">Filter by ISSN.</param>
        /// <param name="hasDigitalIssue">Include only results which are available digitally.</param>
        /// <param name="modifiedSince">Return only comics which have been modified since the specified date.</param>
        /// <param name="creators">Return only comics which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only comics which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only comics which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only comics which take place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only comics which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="sharedAppearances">Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear).</param>
        /// <param name="collaborators">Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetComicsCollection_1 (int? eventId, string format, string formatType, List<bool?> noVariants, List<string> dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, List<bool?> hasDigitalIssue, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> events, List<int?> stories, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of comics filtered by a series id. Fetches lists of comics which are published as part of a specific series, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="seriesId">The series ID.</param>
        /// <param name="format">Filter by the issue format (e.g. comic, digital comic, hardcover).</param>
        /// <param name="formatType">Filter by the issue format type (comic or collection).</param>
        /// <param name="noVariants">Exclude variant comics from the result set.</param>
        /// <param name="dateDescriptor">Return comics within a predefined date range.</param>
        /// <param name="dateRange">Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format.</param>
        /// <param name="title">Return only issues in series whose title matches the input.</param>
        /// <param name="titleStartsWith">Return only issues in series whose title starts with the input.</param>
        /// <param name="startYear">Return only issues in series whose start year matches the input.</param>
        /// <param name="issueNumber">Return only issues in series whose issue number matches the input.</param>
        /// <param name="diamondCode">Filter by diamond code.</param>
        /// <param name="digitalId">Filter by digital comic id.</param>
        /// <param name="upc">Filter by UPC.</param>
        /// <param name="isbn">Filter by ISBN.</param>
        /// <param name="ean">Filter by EAN.</param>
        /// <param name="issn">Filter by ISSN.</param>
        /// <param name="hasDigitalIssue">Include only results which are available digitally.</param>
        /// <param name="modifiedSince">Return only comics which have been modified since the specified date.</param>
        /// <param name="creators">Return only comics which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only comics which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only comics which take place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only comics which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="sharedAppearances">Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear).</param>
        /// <param name="collaborators">Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetComicsCollection_2 (int? seriesId, string format, string formatType, List<bool?> noVariants, List<string> dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, List<bool?> hasDigitalIssue, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> events, List<int?> stories, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of comics. Fetches lists of comics with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="format">Filter by the issue format (e.g. comic, digital comic, hardcover).</param>
        /// <param name="formatType">Filter by the issue format type (comic or collection).</param>
        /// <param name="noVariants">Exclude variants (alternate covers, secondary printings, director&#x27;s cuts, etc.) from the result set.</param>
        /// <param name="dateDescriptor">Return comics within a predefined date range.</param>
        /// <param name="dateRange">Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format.</param>
        /// <param name="title">Return only issues in series whose title matches the input.</param>
        /// <param name="titleStartsWith">Return only issues in series whose title starts with the input.</param>
        /// <param name="startYear">Return only issues in series whose start year matches the input.</param>
        /// <param name="issueNumber">Return only issues in series whose issue number matches the input.</param>
        /// <param name="diamondCode">Filter by diamond code.</param>
        /// <param name="digitalId">Filter by digital comic id.</param>
        /// <param name="upc">Filter by UPC.</param>
        /// <param name="isbn">Filter by ISBN.</param>
        /// <param name="ean">Filter by EAN.</param>
        /// <param name="issn">Filter by ISSN.</param>
        /// <param name="hasDigitalIssue">Include only results which are available digitally.</param>
        /// <param name="modifiedSince">Return only comics which have been modified since the specified date.</param>
        /// <param name="creators">Return only comics which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only comics which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only comics which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only comics which take place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only comics which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="sharedAppearances">Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). Accepts a comma-separated list of ids.</param>
        /// <param name="collaborators">Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). Accepts a comma-separated list of ids.</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetComicsCollection_3 (string format, string formatType, bool? noVariants, string dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, bool? hasDigitalIssue, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> events, List<int?> stories, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of comics filtered by a story id. Fetches lists of comics in which a specific story appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="storyId">The story ID.</param>
        /// <param name="format">Filter by the issue format (e.g. comic, digital comic, hardcover).</param>
        /// <param name="formatType">Filter by the issue format type (comic or collection).</param>
        /// <param name="noVariants">Exclude variant comics from the result set.</param>
        /// <param name="dateDescriptor">Return comics within a predefined date range.</param>
        /// <param name="dateRange">Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format.</param>
        /// <param name="title">Return only issues in series whose title matches the input.</param>
        /// <param name="titleStartsWith">Return only issues in series whose title starts with the input.</param>
        /// <param name="startYear">Return only issues in series whose start year matches the input.</param>
        /// <param name="issueNumber">Return only issues in series whose issue number matches the input.</param>
        /// <param name="diamondCode">Filter by diamond code.</param>
        /// <param name="digitalId">Filter by digital comic id.</param>
        /// <param name="upc">Filter by UPC.</param>
        /// <param name="isbn">Filter by ISBN.</param>
        /// <param name="ean">Filter by EAN.</param>
        /// <param name="issn">Filter by ISSN.</param>
        /// <param name="hasDigitalIssue">Include only results which are available digitally.</param>
        /// <param name="modifiedSince">Return only comics which have been modified since the specified date.</param>
        /// <param name="creators">Return only comics which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only comics which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only comics which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only comics which take place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="sharedAppearances">Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear).</param>
        /// <param name="collaborators">Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetComicsCollection_4 (int? storyId, string format, string formatType, List<bool?> noVariants, List<string> dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, List<bool?> hasDigitalIssue, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> events, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of creators. Fetches lists of comic creators with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="firstName">Filter by creator first name (e.g. Brian).</param>
        /// <param name="middleName">Filter by creator middle name (e.g. Michael).</param>
        /// <param name="lastName">Filter by creator last name (e.g. Bendis).</param>
        /// <param name="suffix">Filter by suffix or honorific (e.g. Jr., Sr.).</param>
        /// <param name="nameStartsWith">Filter by creator names that match critera (e.g. B, St L).</param>
        /// <param name="firstNameStartsWith">Filter by creator first names that match critera (e.g. B, St L).</param>
        /// <param name="middleNameStartsWith">Filter by creator middle names that match critera (e.g. Mi).</param>
        /// <param name="lastNameStartsWith">Filter by creator last names that match critera (e.g. Ben).</param>
        /// <param name="modifiedSince">Return only creators which have been modified since the specified date.</param>
        /// <param name="comics">Return only creators who worked on in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only creators who worked on the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only creators who worked on the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetCreatorCollection (string firstName, string middleName, string lastName, string suffix, string nameStartsWith, string firstNameStartsWith, string middleNameStartsWith, string lastNameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<int?> stories, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of characters filtered by a story id. Fetches lists of comic characters appearing in a single story, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="storyId">The story ID.</param>
        /// <param name="name">Return only characters matching the specified full character name (e.g. Spider-Man).</param>
        /// <param name="nameStartsWith">Return characters with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only characters which have been modified since the specified date.</param>
        /// <param name="comics">Return only characters which appear in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only characters which appear the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetCreatorCollection_5 (int? storyId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of creators filtered by a series id. Fetches lists of comic creators whose work appears in a specific series, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="seriesId">The series ID.</param>
        /// <param name="firstName">Filter by creator first name (e.g. brian).</param>
        /// <param name="middleName">Filter by creator middle name (e.g. Michael).</param>
        /// <param name="lastName">Filter by creator last name (e.g. Bendis).</param>
        /// <param name="suffix">Filter by suffix or honorific (e.g. Jr., Sr.).</param>
        /// <param name="nameStartsWith">Filter by creator names that match critera (e.g. B, St L).</param>
        /// <param name="firstNameStartsWith">Filter by creator first names that match critera (e.g. B, St L).</param>
        /// <param name="middleNameStartsWith">Filter by creator middle names that match critera (e.g. Mi).</param>
        /// <param name="lastNameStartsWith">Filter by creator last names that match critera (e.g. Ben).</param>
        /// <param name="modifiedSince">Return only creators which have been modified since the specified date.</param>
        /// <param name="comics">Return only creators who worked on in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only creators who worked on the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetCreatorCollection_6 (int? seriesId, string firstName, string middleName, string lastName, string suffix, string nameStartsWith, string firstNameStartsWith, string middleNameStartsWith, string lastNameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> events, List<int?> stories, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of creators filtered by a comic id. Fetches lists of comic creators whose work appears in a specific comic, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="comicId">The comic id.</param>
        /// <param name="firstName">Filter by creator first name (e.g. brian).</param>
        /// <param name="middleName">Filter by creator middle name (e.g. Michael).</param>
        /// <param name="lastName">Filter by creator last name (e.g. Bendis).</param>
        /// <param name="suffix">Filter by suffix or honorific (e.g. Jr., Sr.).</param>
        /// <param name="nameStartsWith">Filter by creator names that match critera (e.g. B, St L).</param>
        /// <param name="firstNameStartsWith">Filter by creator first names that match critera (e.g. B, St L).</param>
        /// <param name="middleNameStartsWith">Filter by creator middle names that match critera (e.g. Mi).</param>
        /// <param name="lastNameStartsWith">Filter by creator last names that match critera (e.g. Ben).</param>
        /// <param name="modifiedSince">Return only creators which have been modified since the specified date.</param>
        /// <param name="comics">Return only creators who worked on in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only creators who worked on the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only creators who worked on the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetCreatorCollection_7 (int? comicId, string firstName, string middleName, string lastName, string suffix, string nameStartsWith, string firstNameStartsWith, string middleNameStartsWith, string lastNameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> stories, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of characters. Fetches lists of comic characters with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="name">Return only characters matching the specified full character name (e.g. Spider-Man).</param>
        /// <param name="nameStartsWith">Return characters with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only characters which have been modified since the specified date.</param>
        /// <param name="comics">Return only characters which appear in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only characters which appear the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only characters which appear in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only characters which appear the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetCharacters (string name, string nameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<int?> stories, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of creators filtered by a story id. Fetches lists of comic creators whose work appears in a specific story, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="storyId">The story ID.</param>
        /// <param name="firstName">Filter by creator first name (e.g. brian).</param>
        /// <param name="middleName">Filter by creator middle name (e.g. Michael).</param>
        /// <param name="lastName">Filter by creator last name (e.g. Bendis).</param>
        /// <param name="suffix">Filter by suffix or honorific (e.g. Jr., Sr.).</param>
        /// <param name="nameStartsWith">Filter by creator names that match critera (e.g. B, St L).</param>
        /// <param name="firstNameStartsWith">Filter by creator first names that match critera (e.g. B, St L).</param>
        /// <param name="middleNameStartsWith">Filter by creator middle names that match critera (e.g. Mi).</param>
        /// <param name="lastNameStartsWith">Filter by creator last names that match critera (e.g. Ben).</param>
        /// <param name="modifiedSince">Return only creators which have been modified since the specified date.</param>
        /// <param name="comics">Return only creators who worked on in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only creators who worked on the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetCreatorCollection_9 (int? storyId, string firstName, string middleName, string lastName, string suffix, string nameStartsWith, string firstNameStartsWith, string middleNameStartsWith, string lastNameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of creators filtered by an event id. Fetches lists of comic creators whose work appears in a specific event, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="eventId">The event ID.</param>
        /// <param name="firstName">Filter by creator first name (e.g. brian).</param>
        /// <param name="middleName">Filter by creator middle name (e.g. Michael).</param>
        /// <param name="lastName">Filter by creator last name (e.g. Bendis).</param>
        /// <param name="suffix">Filter by suffix or honorific (e.g. Jr., Sr.).</param>
        /// <param name="nameStartsWith">Filter by creator names that match critera (e.g. B, St L).</param>
        /// <param name="firstNameStartsWith">Filter by creator first names that match critera (e.g. B, St L).</param>
        /// <param name="middleNameStartsWith">Filter by creator middle names that match critera (e.g. Mi).</param>
        /// <param name="lastNameStartsWith">Filter by creator last names that match critera (e.g. Ben).</param>
        /// <param name="modifiedSince">Return only creators which have been modified since the specified date.</param>
        /// <param name="comics">Return only creators who worked on in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only creators who worked on the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only creators who worked on the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetCreatorCollection_10 (int? eventId, string firstName, string middleName, string lastName, string suffix, string nameStartsWith, string firstNameStartsWith, string middleNameStartsWith, string lastNameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> stories, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of events filtered by a creator id. Fetches lists of events featuring the work of a specific creator with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="creatorId">The creator ID.</param>
        /// <param name="name">Filter the event list by name.</param>
        /// <param name="nameStartsWith">Return events with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only events which have been modified since the specified date.</param>
        /// <param name="characters">Return only events which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only events which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="comics">Return only events which take place in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only events which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetCreatorEventsCollection (int? creatorId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> characters, List<int?> series, List<int?> comics, List<int?> stories, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches a single creator by id. This method fetches a single creator resource.  It is the canonical URI for any creator resource provided by the API.
        /// </summary>
        /// <param name="creatorId">A single creator id.</param>
        /// <returns></returns>
        IRestResponse GetCreatorIndividual (int? creatorId);
        /// <summary>
        /// Fetches lists of series filtered by a creator id. Fetches lists of comic series in which a specific creator&#x27;s work appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="creatorId">The creator ID.</param>
        /// <param name="title">Filter by series title.</param>
        /// <param name="titleStartsWith">Return series with titles that begin with the specified string (e.g. Sp).</param>
        /// <param name="startYear">Return only series matching the specified start year.</param>
        /// <param name="modifiedSince">Return only series which have been modified since the specified date.</param>
        /// <param name="comics">Return only series which contain the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only series which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only series which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="seriesType">Filter the series by publication frequency type.</param>
        /// <param name="contains">Return only series containing one or more comics with the specified format.</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetCreatorSeriesCollection (int? creatorId, string title, string titleStartsWith, int? startYear, DateTime? modifiedSince, List<int?> comics, List<int?> stories, List<int?> events, List<int?> characters, string seriesType, List<string> contains, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of stories filtered by a creator id. Fetches lists of comic stories by a specific creator with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="creatorId">The ID of the creator.</param>
        /// <param name="modifiedSince">Return only stories which have been modified since the specified date.</param>
        /// <param name="comics">Return only stories contained in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only stories contained the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only stories which take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only stories which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetCreatorStoryCollection (int? creatorId, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<int?> characters, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of characters filtered by an event id. Fetches lists of characters which appear in a specific event, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="eventId">The event ID</param>
        /// <param name="name">Return only characters matching the specified full character name (e.g. Spider-Man).</param>
        /// <param name="nameStartsWith">Return characters with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only characters which have been modified since the specified date.</param>
        /// <param name="comics">Return only characters which appear in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only characters which appear the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only characters which appear the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetEventCharacterCollection (int? eventId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> stories, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches a single event by id. This method fetches a single event resource.  It is the canonical URI for any event resource provided by the API.
        /// </summary>
        /// <param name="eventId">A single event.</param>
        /// <returns></returns>
        IRestResponse GetEventIndividual (int? eventId);
        /// <summary>
        /// Fetches lists of series filtered by an event id. Fetches lists of comic series in which a specific event takes place, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="eventId">The event ID.</param>
        /// <param name="title">Filter by series title.</param>
        /// <param name="titleStartsWith">Return series with titles that begin with the specified string (e.g. Sp).</param>
        /// <param name="startYear">Return only series matching the specified start year.</param>
        /// <param name="modifiedSince">Return only series which have been modified since the specified date.</param>
        /// <param name="comics">Return only series which contain the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only series which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only series which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only series which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="seriesType">Filter the series by publication frequency type.</param>
        /// <param name="contains">Return only series containing one or more comics with the specified format.</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetEventSeriesCollection (int? eventId, string title, string titleStartsWith, int? startYear, DateTime? modifiedSince, List<int?> comics, List<int?> stories, List<int?> creators, List<int?> characters, string seriesType, List<string> contains, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of stories filtered by an event id. Fetches lists of comic stories from a specific event, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="eventId">The ID of the event.</param>
        /// <param name="modifiedSince">Return only stories which have been modified since the specified date.</param>
        /// <param name="comics">Return only stories contained in the specified (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only stories contained the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only stories which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only stories which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetEventStoryCollection (int? eventId, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> creators, List<int?> characters, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of events filtered by a story id. Fetches lists of events in which a specific story appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="storyId">The story ID.</param>
        /// <param name="name">Filter the event list by name.</param>
        /// <param name="nameStartsWith">Return events with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only events which have been modified since the specified date.</param>
        /// <param name="creators">Return only events which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only events which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only events which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="comics">Return only events which take place in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetEventsCollection (int? storyId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> comics, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of events filtered by a series id. Fetches lists of events which occur in a specific series, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="seriesId">The series ID.</param>
        /// <param name="name">Filter the event list by name.</param>
        /// <param name="nameStartsWith">Return events with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only events which have been modified since the specified date.</param>
        /// <param name="creators">Return only events which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only events which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="comics">Return only events which take place in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only events which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetEventsCollection_11 (int? seriesId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> comics, List<int?> stories, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of events. Fetches lists of events with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="name">Return only events which match the specified name.</param>
        /// <param name="nameStartsWith">Return events with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only events which have been modified since the specified date.</param>
        /// <param name="creators">Return only events which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only events which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only events which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="comics">Return only events which take place in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only events which take place in the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetEventsCollection_12 (string name, string nameStartsWith, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> comics, List<int?> stories, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of events filtered by a comic id. Fetches lists of events in which a specific comic appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="comicId">The comic ID.</param>
        /// <param name="name">Filter the event list by name.</param>
        /// <param name="nameStartsWith">Return events with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only events which have been modified since the specified date.</param>
        /// <param name="creators">Return only events which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only events which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only events which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only events which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetIssueEventsCollection (int? comicId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> stories, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of characters filtered by a series id. Fetches lists of characters which appear in specific series, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="seriesId">The series id.</param>
        /// <param name="name">Return only characters matching the specified full character name (e.g. Spider-Man).</param>
        /// <param name="nameStartsWith">Return characters with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only characters which have been modified since the specified date.</param>
        /// <param name="comics">Return only characters which appear in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only characters which appear the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetSeriesCharacterWrapper (int? seriesId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> events, List<int?> stories, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of series. Fetches lists of comic series with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="title">Return only series matching the specified title.</param>
        /// <param name="titleStartsWith">Return series with titles that begin with the specified string (e.g. Sp).</param>
        /// <param name="startYear">Return only series matching the specified start year.</param>
        /// <param name="modifiedSince">Return only series which have been modified since the specified date.</param>
        /// <param name="comics">Return only series which contain the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only series which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only series which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only series which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="seriesType">Filter the series by publication frequency type.</param>
        /// <param name="contains">Return only series containing one or more comics with the specified format.</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetSeriesCollection (string title, string titleStartsWith, int? startYear, DateTime? modifiedSince, List<int?> comics, List<int?> stories, List<int?> events, List<int?> creators, List<int?> characters, string seriesType, List<string> contains, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches a single comic series by id. This method fetches a single comic series resource.  It is the canonical URI for any comic series resource provided by the API.
        /// </summary>
        /// <param name="seriesId">Filter by series title.</param>
        /// <returns></returns>
        IRestResponse GetSeriesIndividual (int? seriesId);
        /// <summary>
        /// Fetches lists of stories filtered by a series id. Fetches lists of comic stories from a specific series with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="seriesId">The series ID.</param>
        /// <param name="modifiedSince">Return only stories which have been modified since the specified date.</param>
        /// <param name="comics">Return only stories contained in the specified (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only stories which take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only stories which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only stories which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetSeriesStoryCollection (int? seriesId, DateTime? modifiedSince, List<int?> comics, List<int?> events, List<int?> creators, List<int?> characters, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches lists of stories. Fetches lists of comic stories with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="modifiedSince">Return only stories which have been modified since the specified date.</param>
        /// <param name="comics">Return only stories contained in the specified (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only stories contained the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only stories which take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only stories which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only stories which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetStoryCollection (DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<int?> creators, List<int?> characters, List<string> orderBy, int? limit, int? offset);
        /// <summary>
        /// Fetches a single comic story by id. This method fetches a single comic story resource.  It is the canonical URI for any comic story resource provided by the API.
        /// </summary>
        /// <param name="storyId">Filter by story id.</param>
        /// <returns></returns>
        IRestResponse GetStoryIndividual (int? storyId);
        /// <summary>
        /// Fetches lists of series filtered by a story id. Fetches lists of comic series in which the specified story takes place. See notes on individual parameters below.
        /// </summary>
        /// <param name="storyId">The story ID.</param>
        /// <param name="events">Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="title">Filter by series title.</param>
        /// <param name="titleStartsWith">Return series with titles that begin with the specified string (e.g. Sp).</param>
        /// <param name="startYear">Return only series matching the specified start year.</param>
        /// <param name="modifiedSince">Return only series which have been modified since the specified date.</param>
        /// <param name="comics">Return only series which contain the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only series which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only series which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="seriesType">Filter the series by publication frequency type.</param>
        /// <param name="contains">Return only series containing one or more comics with the specified format.</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        IRestResponse GetStorySeriesCollection (int? storyId, List<int?> events, string title, string titleStartsWith, int? startYear, DateTime? modifiedSince, List<int?> comics, List<int?> creators, List<int?> characters, string seriesType, List<string> contains, List<string> orderBy, int? limit, int? offset);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MarvelPublicApi : IMarvelPublicApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarvelPublicApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MarvelPublicApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;

            this.AuthSettings = ApiClient.GetApiAuth();
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MarvelPublicApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MarvelPublicApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
        public string[] AuthSettings { get; private set; } = new string[2] { string.Empty, string.Empty };

        /// <summary>
        /// Fetches lists of events filtered by a character id. Fetches lists of events in which a specific character appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="characterId">The character ID.</param>
        /// <param name="name">Filter the event list by name.</param>
        /// <param name="nameStartsWith">Return events with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only events which have been modified since the specified date.</param>
        /// <param name="creators">Return only events which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only events which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="comics">Return only events which take place in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only events which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetCharacterEventsCollection (int? characterId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> creators, List<int?> series, List<int?> comics, List<int?> stories, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharacterEventsCollection");
    
            var path = "/v1/public/characters/{characterId}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "characterId" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharacterEventsCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharacterEventsCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches a single character by id. This method fetches a single character resource.  It is the canonical URI for any character resource provided by the API.
        /// </summary>
        /// <param name="characterId">A single character id.</param>
        /// <returns></returns>
        public IRestResponse GetCharacterIndividual (int? characterId)
        {
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharacterIndividual");
    
            var path = "/v1/public/characters/{characterId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "characterId" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharacterIndividual: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharacterIndividual: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of series filtered by a character id. Fetches lists of comic series in which a specific character appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="characterId">The character ID</param>
        /// <param name="title">Filter by series title.</param>
        /// <param name="titleStartsWith">Return series with titles that begin with the specified string (e.g. Sp).</param>
        /// <param name="startYear">Return only series matching the specified start year.</param>
        /// <param name="modifiedSince">Return only series which have been modified since the specified date.</param>
        /// <param name="comics">Return only series which contain the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only series which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only series which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="seriesType">Filter the series by publication frequency type.</param>
        /// <param name="contains">Return only series containing one or more comics with the specified format.</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetCharacterSeriesCollection (int? characterId, string title, string titleStartsWith, int? startYear, DateTime? modifiedSince, List<int?> comics, List<int?> stories, List<int?> events, List<int?> creators, string seriesType, List<string> contains, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharacterSeriesCollection");
    
            var path = "/v1/public/characters/{characterId}/series";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "characterId" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (title != null) queryParams.Add("title", ApiClient.ParameterToString(title)); // query parameter
 if (titleStartsWith != null) queryParams.Add("titleStartsWith", ApiClient.ParameterToString(titleStartsWith)); // query parameter
 if (startYear != null) queryParams.Add("startYear", ApiClient.ParameterToString(startYear)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (seriesType != null) queryParams.Add("seriesType", ApiClient.ParameterToString(seriesType)); // query parameter
 if (contains != null) queryParams.Add("contains", ApiClient.ParameterToString(contains)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharacterSeriesCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharacterSeriesCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of stories filtered by a character id. Fetches lists of comic stories  featuring a specific character with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="characterId">The character ID.</param>
        /// <param name="modifiedSince">Return only stories which have been modified since the specified date.</param>
        /// <param name="comics">Return only stories contained in the specified (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only stories contained the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only stories which take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only stories which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetCharacterStoryCollection (int? characterId, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<int?> creators, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharacterStoryCollection");
    
            var path = "/v1/public/characters/{characterId}/stories";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "characterId" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharacterStoryCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharacterStoryCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of characters filtered by a comic id. Fetches lists of characters which appear in a specific comic with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="comicId">The comic id.</param>
        /// <param name="name">Return only characters matching the specified full character name (e.g. Spider-Man).</param>
        /// <param name="nameStartsWith">Return characters with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only characters which have been modified since the specified date.</param>
        /// <param name="series">Return only characters which appear the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only characters which appear the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetComicCharacterCollection (int? comicId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> series, List<int?> events, List<int?> stories, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'comicId' is set
            if (comicId == null) throw new ApiException(400, "Missing required parameter 'comicId' when calling GetComicCharacterCollection");
    
            var path = "/v1/public/comics/{comicId}/characters";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "comicId" + "}", ApiClient.ParameterToString(comicId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicCharacterCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicCharacterCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches a single comic by id. This method fetches a single comic resource.  It is the canonical URI for any comic resource provided by the API.
        /// </summary>
        /// <param name="comicId">A single comic.</param>
        /// <returns></returns>
        public IRestResponse GetComicIndividual (int? comicId)
        {
            // verify the required parameter 'comicId' is set
            if (comicId == null) throw new ApiException(400, "Missing required parameter 'comicId' when calling GetComicIndividual");
    
            var path = "/v1/public/comics/{comicId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "comicId" + "}", ApiClient.ParameterToString(comicId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicIndividual: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicIndividual: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of stories filtered by a comic id. Fetches lists of comic stories in a specific comic issue, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="comicId">The comic ID.</param>
        /// <param name="modifiedSince">Return only stories which have been modified since the specified date.</param>
        /// <param name="series">Return only stories contained the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only stories which take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only stories which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only stories which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources.</param>
        /// <returns></returns>
        public IRestResponse GetComicStoryCollection (int? comicId, DateTime? modifiedSince, List<int?> series, List<int?> events, List<int?> creators, List<int?> characters, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'comicId' is set
            if (comicId == null) throw new ApiException(400, "Missing required parameter 'comicId' when calling GetComicStoryCollection");
    
            var path = "/v1/public/comics/{comicId}/stories";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "comicId" + "}", ApiClient.ParameterToString(comicId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicStoryCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicStoryCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of comics filtered by a character id. Fetches lists of comics containing a specific character, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="characterId">The character id.</param>
        /// <param name="format">Filter by the issue format (e.g. comic, digital comic, hardcover).</param>
        /// <param name="formatType">Filter by the issue format type (comic or collection).</param>
        /// <param name="noVariants">Exclude variant comics from the result set.</param>
        /// <param name="dateDescriptor">Return comics within a predefined date range.</param>
        /// <param name="dateRange">Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format.</param>
        /// <param name="title">Return only issues in series whose title matches the input.</param>
        /// <param name="titleStartsWith">Return only issues in series whose title starts with the input.</param>
        /// <param name="startYear">Return only issues in series whose start year matches the input.</param>
        /// <param name="issueNumber">Return only issues in series whose issue number matches the input.</param>
        /// <param name="diamondCode">Filter by diamond code.</param>
        /// <param name="digitalId">Filter by digital comic id.</param>
        /// <param name="upc">Filter by UPC.</param>
        /// <param name="isbn">Filter by ISBN.</param>
        /// <param name="ean">Filter by EAN.</param>
        /// <param name="issn">Filter by ISSN.</param>
        /// <param name="hasDigitalIssue">Include only results which are available digitally.</param>
        /// <param name="modifiedSince">Return only comics which have been modified since the specified date.</param>
        /// <param name="creators">Return only comics which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only comics which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only comics which take place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only comics which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="sharedAppearances">Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear).</param>
        /// <param name="collaborators">Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetComicsCharacterCollection (int? characterId, string format, string formatType, bool? noVariants, string dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, bool? hasDigitalIssue, DateTime? modifiedSince, List<int?> creators, List<int?> series, List<int?> events, List<int?> stories, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetComicsCharacterCollection");
    
            var path = "/v1/public/characters/{characterId}/comics";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "characterId" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
 if (formatType != null) queryParams.Add("formatType", ApiClient.ParameterToString(formatType)); // query parameter
 if (noVariants != null) queryParams.Add("noVariants", ApiClient.ParameterToString(noVariants)); // query parameter
 if (dateDescriptor != null) queryParams.Add("dateDescriptor", ApiClient.ParameterToString(dateDescriptor)); // query parameter
 if (dateRange != null) queryParams.Add("dateRange", ApiClient.ParameterToString(dateRange)); // query parameter
 if (title != null) queryParams.Add("title", ApiClient.ParameterToString(title)); // query parameter
 if (titleStartsWith != null) queryParams.Add("titleStartsWith", ApiClient.ParameterToString(titleStartsWith)); // query parameter
 if (startYear != null) queryParams.Add("startYear", ApiClient.ParameterToString(startYear)); // query parameter
 if (issueNumber != null) queryParams.Add("issueNumber", ApiClient.ParameterToString(issueNumber)); // query parameter
 if (diamondCode != null) queryParams.Add("diamondCode", ApiClient.ParameterToString(diamondCode)); // query parameter
 if (digitalId != null) queryParams.Add("digitalId", ApiClient.ParameterToString(digitalId)); // query parameter
 if (upc != null) queryParams.Add("upc", ApiClient.ParameterToString(upc)); // query parameter
 if (isbn != null) queryParams.Add("isbn", ApiClient.ParameterToString(isbn)); // query parameter
 if (ean != null) queryParams.Add("ean", ApiClient.ParameterToString(ean)); // query parameter
 if (issn != null) queryParams.Add("issn", ApiClient.ParameterToString(issn)); // query parameter
 if (hasDigitalIssue != null) queryParams.Add("hasDigitalIssue", ApiClient.ParameterToString(hasDigitalIssue)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (sharedAppearances != null) queryParams.Add("sharedAppearances", ApiClient.ParameterToString(sharedAppearances)); // query parameter
 if (collaborators != null) queryParams.Add("collaborators", ApiClient.ParameterToString(collaborators)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicsCharacterCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicsCharacterCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of comics filtered by a creator id. Fetches lists of comics in which the work of a specific creator appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="creatorId">The creator ID.</param>
        /// <param name="format">Filter by the issue format (e.g. comic, digital comic, hardcover).</param>
        /// <param name="formatType">Filter by the issue format type (comic or collection).</param>
        /// <param name="noVariants">Exclude variant comics from the result set.</param>
        /// <param name="dateDescriptor">Return comics within a predefined date range.</param>
        /// <param name="dateRange">Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format.</param>
        /// <param name="title">Return only issues in series whose title matches the input.</param>
        /// <param name="titleStartsWith">Return only issues in series whose title starts with the input.</param>
        /// <param name="startYear">Return only issues in series whose start year matches the input.</param>
        /// <param name="issueNumber">Return only issues in series whose issue number matches the input.</param>
        /// <param name="diamondCode">Filter by diamond code.</param>
        /// <param name="digitalId">Filter by digital comic id.</param>
        /// <param name="upc">Filter by UPC.</param>
        /// <param name="isbn">Filter by ISBN.</param>
        /// <param name="ean">Filter by EAN.</param>
        /// <param name="issn">Filter by ISSN.</param>
        /// <param name="hasDigitalIssue">Include only results which are available digitally.</param>
        /// <param name="modifiedSince">Return only comics which have been modified since the specified date.</param>
        /// <param name="characters">Return only comics which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only comics which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only comics which take place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only comics which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="sharedAppearances">Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear).</param>
        /// <param name="collaborators">Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetComicsCollection (int? creatorId, string format, string formatType, bool? noVariants, string dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, List<bool?> hasDigitalIssue, DateTime? modifiedSince, List<int?> characters, List<int?> series, List<int?> events, List<int?> stories, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'creatorId' is set
            if (creatorId == null) throw new ApiException(400, "Missing required parameter 'creatorId' when calling GetComicsCollection");
    
            var path = "/v1/public/creators/{creatorId}/comics";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "creatorId" + "}", ApiClient.ParameterToString(creatorId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
 if (formatType != null) queryParams.Add("formatType", ApiClient.ParameterToString(formatType)); // query parameter
 if (noVariants != null) queryParams.Add("noVariants", ApiClient.ParameterToString(noVariants)); // query parameter
 if (dateDescriptor != null) queryParams.Add("dateDescriptor", ApiClient.ParameterToString(dateDescriptor)); // query parameter
 if (dateRange != null) queryParams.Add("dateRange", ApiClient.ParameterToString(dateRange)); // query parameter
 if (title != null) queryParams.Add("title", ApiClient.ParameterToString(title)); // query parameter
 if (titleStartsWith != null) queryParams.Add("titleStartsWith", ApiClient.ParameterToString(titleStartsWith)); // query parameter
 if (startYear != null) queryParams.Add("startYear", ApiClient.ParameterToString(startYear)); // query parameter
 if (issueNumber != null) queryParams.Add("issueNumber", ApiClient.ParameterToString(issueNumber)); // query parameter
 if (diamondCode != null) queryParams.Add("diamondCode", ApiClient.ParameterToString(diamondCode)); // query parameter
 if (digitalId != null) queryParams.Add("digitalId", ApiClient.ParameterToString(digitalId)); // query parameter
 if (upc != null) queryParams.Add("upc", ApiClient.ParameterToString(upc)); // query parameter
 if (isbn != null) queryParams.Add("isbn", ApiClient.ParameterToString(isbn)); // query parameter
 if (ean != null) queryParams.Add("ean", ApiClient.ParameterToString(ean)); // query parameter
 if (issn != null) queryParams.Add("issn", ApiClient.ParameterToString(issn)); // query parameter
 if (hasDigitalIssue != null) queryParams.Add("hasDigitalIssue", ApiClient.ParameterToString(hasDigitalIssue)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (sharedAppearances != null) queryParams.Add("sharedAppearances", ApiClient.ParameterToString(sharedAppearances)); // query parameter
 if (collaborators != null) queryParams.Add("collaborators", ApiClient.ParameterToString(collaborators)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicsCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicsCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of comics filtered by an event id. Fetches lists of comics which take place during a specific event, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="eventId">The event id.</param>
        /// <param name="format">Filter by the issue format (e.g. comic, digital comic, hardcover).</param>
        /// <param name="formatType">Filter by the issue format type (comic or collection).</param>
        /// <param name="noVariants">Exclude variant comics from the result set.</param>
        /// <param name="dateDescriptor">Return comics within a predefined date range.</param>
        /// <param name="dateRange">Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format.</param>
        /// <param name="title">Return only issues in series whose title matches the input.</param>
        /// <param name="titleStartsWith">Return only issues in series whose title starts with the input.</param>
        /// <param name="startYear">Return only issues in series whose start year matches the input.</param>
        /// <param name="issueNumber">Return only issues in series whose issue number matches the input.</param>
        /// <param name="diamondCode">Filter by diamond code.</param>
        /// <param name="digitalId">Filter by digital comic id.</param>
        /// <param name="upc">Filter by UPC.</param>
        /// <param name="isbn">Filter by ISBN.</param>
        /// <param name="ean">Filter by EAN.</param>
        /// <param name="issn">Filter by ISSN.</param>
        /// <param name="hasDigitalIssue">Include only results which are available digitally.</param>
        /// <param name="modifiedSince">Return only comics which have been modified since the specified date.</param>
        /// <param name="creators">Return only comics which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only comics which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only comics which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only comics which take place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only comics which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="sharedAppearances">Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear).</param>
        /// <param name="collaborators">Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetComicsCollection_1 (int? eventId, string format, string formatType, List<bool?> noVariants, List<string> dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, List<bool?> hasDigitalIssue, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> events, List<int?> stories, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'eventId' is set
            if (eventId == null) throw new ApiException(400, "Missing required parameter 'eventId' when calling GetComicsCollection_1");
    
            var path = "/v1/public/events/{eventId}/comics";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "eventId" + "}", ApiClient.ParameterToString(eventId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
 if (formatType != null) queryParams.Add("formatType", ApiClient.ParameterToString(formatType)); // query parameter
 if (noVariants != null) queryParams.Add("noVariants", ApiClient.ParameterToString(noVariants)); // query parameter
 if (dateDescriptor != null) queryParams.Add("dateDescriptor", ApiClient.ParameterToString(dateDescriptor)); // query parameter
 if (dateRange != null) queryParams.Add("dateRange", ApiClient.ParameterToString(dateRange)); // query parameter
 if (title != null) queryParams.Add("title", ApiClient.ParameterToString(title)); // query parameter
 if (titleStartsWith != null) queryParams.Add("titleStartsWith", ApiClient.ParameterToString(titleStartsWith)); // query parameter
 if (startYear != null) queryParams.Add("startYear", ApiClient.ParameterToString(startYear)); // query parameter
 if (issueNumber != null) queryParams.Add("issueNumber", ApiClient.ParameterToString(issueNumber)); // query parameter
 if (diamondCode != null) queryParams.Add("diamondCode", ApiClient.ParameterToString(diamondCode)); // query parameter
 if (digitalId != null) queryParams.Add("digitalId", ApiClient.ParameterToString(digitalId)); // query parameter
 if (upc != null) queryParams.Add("upc", ApiClient.ParameterToString(upc)); // query parameter
 if (isbn != null) queryParams.Add("isbn", ApiClient.ParameterToString(isbn)); // query parameter
 if (ean != null) queryParams.Add("ean", ApiClient.ParameterToString(ean)); // query parameter
 if (issn != null) queryParams.Add("issn", ApiClient.ParameterToString(issn)); // query parameter
 if (hasDigitalIssue != null) queryParams.Add("hasDigitalIssue", ApiClient.ParameterToString(hasDigitalIssue)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (sharedAppearances != null) queryParams.Add("sharedAppearances", ApiClient.ParameterToString(sharedAppearances)); // query parameter
 if (collaborators != null) queryParams.Add("collaborators", ApiClient.ParameterToString(collaborators)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicsCollection_1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicsCollection_1: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of comics filtered by a series id. Fetches lists of comics which are published as part of a specific series, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="seriesId">The series ID.</param>
        /// <param name="format">Filter by the issue format (e.g. comic, digital comic, hardcover).</param>
        /// <param name="formatType">Filter by the issue format type (comic or collection).</param>
        /// <param name="noVariants">Exclude variant comics from the result set.</param>
        /// <param name="dateDescriptor">Return comics within a predefined date range.</param>
        /// <param name="dateRange">Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format.</param>
        /// <param name="title">Return only issues in series whose title matches the input.</param>
        /// <param name="titleStartsWith">Return only issues in series whose title starts with the input.</param>
        /// <param name="startYear">Return only issues in series whose start year matches the input.</param>
        /// <param name="issueNumber">Return only issues in series whose issue number matches the input.</param>
        /// <param name="diamondCode">Filter by diamond code.</param>
        /// <param name="digitalId">Filter by digital comic id.</param>
        /// <param name="upc">Filter by UPC.</param>
        /// <param name="isbn">Filter by ISBN.</param>
        /// <param name="ean">Filter by EAN.</param>
        /// <param name="issn">Filter by ISSN.</param>
        /// <param name="hasDigitalIssue">Include only results which are available digitally.</param>
        /// <param name="modifiedSince">Return only comics which have been modified since the specified date.</param>
        /// <param name="creators">Return only comics which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only comics which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only comics which take place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only comics which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="sharedAppearances">Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear).</param>
        /// <param name="collaborators">Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetComicsCollection_2 (int? seriesId, string format, string formatType, List<bool?> noVariants, List<string> dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, List<bool?> hasDigitalIssue, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> events, List<int?> stories, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'seriesId' is set
            if (seriesId == null) throw new ApiException(400, "Missing required parameter 'seriesId' when calling GetComicsCollection_2");
    
            var path = "/v1/public/series/{seriesId}/comics";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "seriesId" + "}", ApiClient.ParameterToString(seriesId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
 if (formatType != null) queryParams.Add("formatType", ApiClient.ParameterToString(formatType)); // query parameter
 if (noVariants != null) queryParams.Add("noVariants", ApiClient.ParameterToString(noVariants)); // query parameter
 if (dateDescriptor != null) queryParams.Add("dateDescriptor", ApiClient.ParameterToString(dateDescriptor)); // query parameter
 if (dateRange != null) queryParams.Add("dateRange", ApiClient.ParameterToString(dateRange)); // query parameter
 if (title != null) queryParams.Add("title", ApiClient.ParameterToString(title)); // query parameter
 if (titleStartsWith != null) queryParams.Add("titleStartsWith", ApiClient.ParameterToString(titleStartsWith)); // query parameter
 if (startYear != null) queryParams.Add("startYear", ApiClient.ParameterToString(startYear)); // query parameter
 if (issueNumber != null) queryParams.Add("issueNumber", ApiClient.ParameterToString(issueNumber)); // query parameter
 if (diamondCode != null) queryParams.Add("diamondCode", ApiClient.ParameterToString(diamondCode)); // query parameter
 if (digitalId != null) queryParams.Add("digitalId", ApiClient.ParameterToString(digitalId)); // query parameter
 if (upc != null) queryParams.Add("upc", ApiClient.ParameterToString(upc)); // query parameter
 if (isbn != null) queryParams.Add("isbn", ApiClient.ParameterToString(isbn)); // query parameter
 if (ean != null) queryParams.Add("ean", ApiClient.ParameterToString(ean)); // query parameter
 if (issn != null) queryParams.Add("issn", ApiClient.ParameterToString(issn)); // query parameter
 if (hasDigitalIssue != null) queryParams.Add("hasDigitalIssue", ApiClient.ParameterToString(hasDigitalIssue)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (sharedAppearances != null) queryParams.Add("sharedAppearances", ApiClient.ParameterToString(sharedAppearances)); // query parameter
 if (collaborators != null) queryParams.Add("collaborators", ApiClient.ParameterToString(collaborators)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicsCollection_2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicsCollection_2: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of comics. Fetches lists of comics with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="format">Filter by the issue format (e.g. comic, digital comic, hardcover).</param>
        /// <param name="formatType">Filter by the issue format type (comic or collection).</param>
        /// <param name="noVariants">Exclude variants (alternate covers, secondary printings, director&#x27;s cuts, etc.) from the result set.</param>
        /// <param name="dateDescriptor">Return comics within a predefined date range.</param>
        /// <param name="dateRange">Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format.</param>
        /// <param name="title">Return only issues in series whose title matches the input.</param>
        /// <param name="titleStartsWith">Return only issues in series whose title starts with the input.</param>
        /// <param name="startYear">Return only issues in series whose start year matches the input.</param>
        /// <param name="issueNumber">Return only issues in series whose issue number matches the input.</param>
        /// <param name="diamondCode">Filter by diamond code.</param>
        /// <param name="digitalId">Filter by digital comic id.</param>
        /// <param name="upc">Filter by UPC.</param>
        /// <param name="isbn">Filter by ISBN.</param>
        /// <param name="ean">Filter by EAN.</param>
        /// <param name="issn">Filter by ISSN.</param>
        /// <param name="hasDigitalIssue">Include only results which are available digitally.</param>
        /// <param name="modifiedSince">Return only comics which have been modified since the specified date.</param>
        /// <param name="creators">Return only comics which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only comics which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only comics which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only comics which take place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only comics which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="sharedAppearances">Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). Accepts a comma-separated list of ids.</param>
        /// <param name="collaborators">Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). Accepts a comma-separated list of ids.</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetComicsCollection_3 (string format, string formatType, bool? noVariants, string dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, bool? hasDigitalIssue, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> events, List<int?> stories, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset)
        {
    
            var path = "/v1/public/comics";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
 if (formatType != null) queryParams.Add("formatType", ApiClient.ParameterToString(formatType)); // query parameter
 if (noVariants != null) queryParams.Add("noVariants", ApiClient.ParameterToString(noVariants)); // query parameter
 if (dateDescriptor != null) queryParams.Add("dateDescriptor", ApiClient.ParameterToString(dateDescriptor)); // query parameter
 if (dateRange != null) queryParams.Add("dateRange", ApiClient.ParameterToString(dateRange)); // query parameter
 if (title != null) queryParams.Add("title", ApiClient.ParameterToString(title)); // query parameter
 if (titleStartsWith != null) queryParams.Add("titleStartsWith", ApiClient.ParameterToString(titleStartsWith)); // query parameter
 if (startYear != null) queryParams.Add("startYear", ApiClient.ParameterToString(startYear)); // query parameter
 if (issueNumber != null) queryParams.Add("issueNumber", ApiClient.ParameterToString(issueNumber)); // query parameter
 if (diamondCode != null) queryParams.Add("diamondCode", ApiClient.ParameterToString(diamondCode)); // query parameter
 if (digitalId != null) queryParams.Add("digitalId", ApiClient.ParameterToString(digitalId)); // query parameter
 if (upc != null) queryParams.Add("upc", ApiClient.ParameterToString(upc)); // query parameter
 if (isbn != null) queryParams.Add("isbn", ApiClient.ParameterToString(isbn)); // query parameter
 if (ean != null) queryParams.Add("ean", ApiClient.ParameterToString(ean)); // query parameter
 if (issn != null) queryParams.Add("issn", ApiClient.ParameterToString(issn)); // query parameter
 if (hasDigitalIssue != null) queryParams.Add("hasDigitalIssue", ApiClient.ParameterToString(hasDigitalIssue)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (sharedAppearances != null) queryParams.Add("sharedAppearances", ApiClient.ParameterToString(sharedAppearances)); // query parameter
 if (collaborators != null) queryParams.Add("collaborators", ApiClient.ParameterToString(collaborators)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicsCollection_3: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicsCollection_3: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of comics filtered by a story id. Fetches lists of comics in which a specific story appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="storyId">The story ID.</param>
        /// <param name="format">Filter by the issue format (e.g. comic, digital comic, hardcover).</param>
        /// <param name="formatType">Filter by the issue format type (comic or collection).</param>
        /// <param name="noVariants">Exclude variant comics from the result set.</param>
        /// <param name="dateDescriptor">Return comics within a predefined date range.</param>
        /// <param name="dateRange">Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format.</param>
        /// <param name="title">Return only issues in series whose title matches the input.</param>
        /// <param name="titleStartsWith">Return only issues in series whose title starts with the input.</param>
        /// <param name="startYear">Return only issues in series whose start year matches the input.</param>
        /// <param name="issueNumber">Return only issues in series whose issue number matches the input.</param>
        /// <param name="diamondCode">Filter by diamond code.</param>
        /// <param name="digitalId">Filter by digital comic id.</param>
        /// <param name="upc">Filter by UPC.</param>
        /// <param name="isbn">Filter by ISBN.</param>
        /// <param name="ean">Filter by EAN.</param>
        /// <param name="issn">Filter by ISSN.</param>
        /// <param name="hasDigitalIssue">Include only results which are available digitally.</param>
        /// <param name="modifiedSince">Return only comics which have been modified since the specified date.</param>
        /// <param name="creators">Return only comics which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only comics which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only comics which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only comics which take place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="sharedAppearances">Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear).</param>
        /// <param name="collaborators">Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetComicsCollection_4 (int? storyId, string format, string formatType, List<bool?> noVariants, List<string> dateDescriptor, List<int?> dateRange, string title, string titleStartsWith, int? startYear, int? issueNumber, string diamondCode, int? digitalId, string upc, string isbn, string ean, string issn, List<bool?> hasDigitalIssue, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> events, List<int?> sharedAppearances, List<int?> collaborators, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'storyId' is set
            if (storyId == null) throw new ApiException(400, "Missing required parameter 'storyId' when calling GetComicsCollection_4");
    
            var path = "/v1/public/stories/{storyId}/comics";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "storyId" + "}", ApiClient.ParameterToString(storyId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
 if (formatType != null) queryParams.Add("formatType", ApiClient.ParameterToString(formatType)); // query parameter
 if (noVariants != null) queryParams.Add("noVariants", ApiClient.ParameterToString(noVariants)); // query parameter
 if (dateDescriptor != null) queryParams.Add("dateDescriptor", ApiClient.ParameterToString(dateDescriptor)); // query parameter
 if (dateRange != null) queryParams.Add("dateRange", ApiClient.ParameterToString(dateRange)); // query parameter
 if (title != null) queryParams.Add("title", ApiClient.ParameterToString(title)); // query parameter
 if (titleStartsWith != null) queryParams.Add("titleStartsWith", ApiClient.ParameterToString(titleStartsWith)); // query parameter
 if (startYear != null) queryParams.Add("startYear", ApiClient.ParameterToString(startYear)); // query parameter
 if (issueNumber != null) queryParams.Add("issueNumber", ApiClient.ParameterToString(issueNumber)); // query parameter
 if (diamondCode != null) queryParams.Add("diamondCode", ApiClient.ParameterToString(diamondCode)); // query parameter
 if (digitalId != null) queryParams.Add("digitalId", ApiClient.ParameterToString(digitalId)); // query parameter
 if (upc != null) queryParams.Add("upc", ApiClient.ParameterToString(upc)); // query parameter
 if (isbn != null) queryParams.Add("isbn", ApiClient.ParameterToString(isbn)); // query parameter
 if (ean != null) queryParams.Add("ean", ApiClient.ParameterToString(ean)); // query parameter
 if (issn != null) queryParams.Add("issn", ApiClient.ParameterToString(issn)); // query parameter
 if (hasDigitalIssue != null) queryParams.Add("hasDigitalIssue", ApiClient.ParameterToString(hasDigitalIssue)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (sharedAppearances != null) queryParams.Add("sharedAppearances", ApiClient.ParameterToString(sharedAppearances)); // query parameter
 if (collaborators != null) queryParams.Add("collaborators", ApiClient.ParameterToString(collaborators)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicsCollection_4: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComicsCollection_4: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of creators. Fetches lists of comic creators with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="firstName">Filter by creator first name (e.g. Brian).</param>
        /// <param name="middleName">Filter by creator middle name (e.g. Michael).</param>
        /// <param name="lastName">Filter by creator last name (e.g. Bendis).</param>
        /// <param name="suffix">Filter by suffix or honorific (e.g. Jr., Sr.).</param>
        /// <param name="nameStartsWith">Filter by creator names that match critera (e.g. B, St L).</param>
        /// <param name="firstNameStartsWith">Filter by creator first names that match critera (e.g. B, St L).</param>
        /// <param name="middleNameStartsWith">Filter by creator middle names that match critera (e.g. Mi).</param>
        /// <param name="lastNameStartsWith">Filter by creator last names that match critera (e.g. Ben).</param>
        /// <param name="modifiedSince">Return only creators which have been modified since the specified date.</param>
        /// <param name="comics">Return only creators who worked on in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only creators who worked on the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only creators who worked on the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetCreatorCollection (string firstName, string middleName, string lastName, string suffix, string nameStartsWith, string firstNameStartsWith, string middleNameStartsWith, string lastNameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<int?> stories, List<string> orderBy, int? limit, int? offset)
        {
    
            var path = "/v1/public/creators";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (firstName != null) queryParams.Add("firstName", ApiClient.ParameterToString(firstName)); // query parameter
 if (middleName != null) queryParams.Add("middleName", ApiClient.ParameterToString(middleName)); // query parameter
 if (lastName != null) queryParams.Add("lastName", ApiClient.ParameterToString(lastName)); // query parameter
 if (suffix != null) queryParams.Add("suffix", ApiClient.ParameterToString(suffix)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (firstNameStartsWith != null) queryParams.Add("firstNameStartsWith", ApiClient.ParameterToString(firstNameStartsWith)); // query parameter
 if (middleNameStartsWith != null) queryParams.Add("middleNameStartsWith", ApiClient.ParameterToString(middleNameStartsWith)); // query parameter
 if (lastNameStartsWith != null) queryParams.Add("lastNameStartsWith", ApiClient.ParameterToString(lastNameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of characters filtered by a story id. Fetches lists of comic characters appearing in a single story, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="storyId">The story ID.</param>
        /// <param name="name">Return only characters matching the specified full character name (e.g. Spider-Man).</param>
        /// <param name="nameStartsWith">Return characters with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only characters which have been modified since the specified date.</param>
        /// <param name="comics">Return only characters which appear in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only characters which appear the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetCreatorCollection_5 (int? storyId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'storyId' is set
            if (storyId == null) throw new ApiException(400, "Missing required parameter 'storyId' when calling GetCreatorCollection_5");
    
            var path = "/v1/public/stories/{storyId}/characters";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "storyId" + "}", ApiClient.ParameterToString(storyId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorCollection_5: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorCollection_5: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of creators filtered by a series id. Fetches lists of comic creators whose work appears in a specific series, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="seriesId">The series ID.</param>
        /// <param name="firstName">Filter by creator first name (e.g. brian).</param>
        /// <param name="middleName">Filter by creator middle name (e.g. Michael).</param>
        /// <param name="lastName">Filter by creator last name (e.g. Bendis).</param>
        /// <param name="suffix">Filter by suffix or honorific (e.g. Jr., Sr.).</param>
        /// <param name="nameStartsWith">Filter by creator names that match critera (e.g. B, St L).</param>
        /// <param name="firstNameStartsWith">Filter by creator first names that match critera (e.g. B, St L).</param>
        /// <param name="middleNameStartsWith">Filter by creator middle names that match critera (e.g. Mi).</param>
        /// <param name="lastNameStartsWith">Filter by creator last names that match critera (e.g. Ben).</param>
        /// <param name="modifiedSince">Return only creators which have been modified since the specified date.</param>
        /// <param name="comics">Return only creators who worked on in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only creators who worked on the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetCreatorCollection_6 (int? seriesId, string firstName, string middleName, string lastName, string suffix, string nameStartsWith, string firstNameStartsWith, string middleNameStartsWith, string lastNameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> events, List<int?> stories, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'seriesId' is set
            if (seriesId == null) throw new ApiException(400, "Missing required parameter 'seriesId' when calling GetCreatorCollection_6");
    
            var path = "/v1/public/series/{seriesId}/creators";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "seriesId" + "}", ApiClient.ParameterToString(seriesId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (firstName != null) queryParams.Add("firstName", ApiClient.ParameterToString(firstName)); // query parameter
 if (middleName != null) queryParams.Add("middleName", ApiClient.ParameterToString(middleName)); // query parameter
 if (lastName != null) queryParams.Add("lastName", ApiClient.ParameterToString(lastName)); // query parameter
 if (suffix != null) queryParams.Add("suffix", ApiClient.ParameterToString(suffix)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (firstNameStartsWith != null) queryParams.Add("firstNameStartsWith", ApiClient.ParameterToString(firstNameStartsWith)); // query parameter
 if (middleNameStartsWith != null) queryParams.Add("middleNameStartsWith", ApiClient.ParameterToString(middleNameStartsWith)); // query parameter
 if (lastNameStartsWith != null) queryParams.Add("lastNameStartsWith", ApiClient.ParameterToString(lastNameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorCollection_6: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorCollection_6: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of creators filtered by a comic id. Fetches lists of comic creators whose work appears in a specific comic, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="comicId">The comic id.</param>
        /// <param name="firstName">Filter by creator first name (e.g. brian).</param>
        /// <param name="middleName">Filter by creator middle name (e.g. Michael).</param>
        /// <param name="lastName">Filter by creator last name (e.g. Bendis).</param>
        /// <param name="suffix">Filter by suffix or honorific (e.g. Jr., Sr.).</param>
        /// <param name="nameStartsWith">Filter by creator names that match critera (e.g. B, St L).</param>
        /// <param name="firstNameStartsWith">Filter by creator first names that match critera (e.g. B, St L).</param>
        /// <param name="middleNameStartsWith">Filter by creator middle names that match critera (e.g. Mi).</param>
        /// <param name="lastNameStartsWith">Filter by creator last names that match critera (e.g. Ben).</param>
        /// <param name="modifiedSince">Return only creators which have been modified since the specified date.</param>
        /// <param name="comics">Return only creators who worked on in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only creators who worked on the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only creators who worked on the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetCreatorCollection_7 (int? comicId, string firstName, string middleName, string lastName, string suffix, string nameStartsWith, string firstNameStartsWith, string middleNameStartsWith, string lastNameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> stories, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'comicId' is set
            if (comicId == null) throw new ApiException(400, "Missing required parameter 'comicId' when calling GetCreatorCollection_7");
    
            var path = "/v1/public/comics/{comicId}/creators";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "comicId" + "}", ApiClient.ParameterToString(comicId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (firstName != null) queryParams.Add("firstName", ApiClient.ParameterToString(firstName)); // query parameter
 if (middleName != null) queryParams.Add("middleName", ApiClient.ParameterToString(middleName)); // query parameter
 if (lastName != null) queryParams.Add("lastName", ApiClient.ParameterToString(lastName)); // query parameter
 if (suffix != null) queryParams.Add("suffix", ApiClient.ParameterToString(suffix)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (firstNameStartsWith != null) queryParams.Add("firstNameStartsWith", ApiClient.ParameterToString(firstNameStartsWith)); // query parameter
 if (middleNameStartsWith != null) queryParams.Add("middleNameStartsWith", ApiClient.ParameterToString(middleNameStartsWith)); // query parameter
 if (lastNameStartsWith != null) queryParams.Add("lastNameStartsWith", ApiClient.ParameterToString(lastNameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorCollection_7: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorCollection_7: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of characters. Fetches lists of comic characters with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="name">Return only characters matching the specified full character name (e.g. Spider-Man).</param>
        /// <param name="nameStartsWith">Return characters with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only characters which have been modified since the specified date.</param>
        /// <param name="comics">Return only characters which appear in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only characters which appear the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only characters which appear in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only characters which appear the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetCharacters (string name, string nameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<int?> stories, List<string> orderBy, int? limit, int? offset)
        {
    
            var path = "/v1/public/characters";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharacters: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharacters: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of creators filtered by a story id. Fetches lists of comic creators whose work appears in a specific story, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="storyId">The story ID.</param>
        /// <param name="firstName">Filter by creator first name (e.g. brian).</param>
        /// <param name="middleName">Filter by creator middle name (e.g. Michael).</param>
        /// <param name="lastName">Filter by creator last name (e.g. Bendis).</param>
        /// <param name="suffix">Filter by suffix or honorific (e.g. Jr., Sr.).</param>
        /// <param name="nameStartsWith">Filter by creator names that match critera (e.g. B, St L).</param>
        /// <param name="firstNameStartsWith">Filter by creator first names that match critera (e.g. B, St L).</param>
        /// <param name="middleNameStartsWith">Filter by creator middle names that match critera (e.g. Mi).</param>
        /// <param name="lastNameStartsWith">Filter by creator last names that match critera (e.g. Ben).</param>
        /// <param name="modifiedSince">Return only creators which have been modified since the specified date.</param>
        /// <param name="comics">Return only creators who worked on in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only creators who worked on the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetCreatorCollection_9 (int? storyId, string firstName, string middleName, string lastName, string suffix, string nameStartsWith, string firstNameStartsWith, string middleNameStartsWith, string lastNameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'storyId' is set
            if (storyId == null) throw new ApiException(400, "Missing required parameter 'storyId' when calling GetCreatorCollection_9");
    
            var path = "/v1/public/stories/{storyId}/creators";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "storyId" + "}", ApiClient.ParameterToString(storyId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (firstName != null) queryParams.Add("firstName", ApiClient.ParameterToString(firstName)); // query parameter
 if (middleName != null) queryParams.Add("middleName", ApiClient.ParameterToString(middleName)); // query parameter
 if (lastName != null) queryParams.Add("lastName", ApiClient.ParameterToString(lastName)); // query parameter
 if (suffix != null) queryParams.Add("suffix", ApiClient.ParameterToString(suffix)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (firstNameStartsWith != null) queryParams.Add("firstNameStartsWith", ApiClient.ParameterToString(firstNameStartsWith)); // query parameter
 if (middleNameStartsWith != null) queryParams.Add("middleNameStartsWith", ApiClient.ParameterToString(middleNameStartsWith)); // query parameter
 if (lastNameStartsWith != null) queryParams.Add("lastNameStartsWith", ApiClient.ParameterToString(lastNameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorCollection_9: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorCollection_9: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of creators filtered by an event id. Fetches lists of comic creators whose work appears in a specific event, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="eventId">The event ID.</param>
        /// <param name="firstName">Filter by creator first name (e.g. brian).</param>
        /// <param name="middleName">Filter by creator middle name (e.g. Michael).</param>
        /// <param name="lastName">Filter by creator last name (e.g. Bendis).</param>
        /// <param name="suffix">Filter by suffix or honorific (e.g. Jr., Sr.).</param>
        /// <param name="nameStartsWith">Filter by creator names that match critera (e.g. B, St L).</param>
        /// <param name="firstNameStartsWith">Filter by creator first names that match critera (e.g. B, St L).</param>
        /// <param name="middleNameStartsWith">Filter by creator middle names that match critera (e.g. Mi).</param>
        /// <param name="lastNameStartsWith">Filter by creator last names that match critera (e.g. Ben).</param>
        /// <param name="modifiedSince">Return only creators which have been modified since the specified date.</param>
        /// <param name="comics">Return only creators who worked on in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only creators who worked on the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only creators who worked on the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetCreatorCollection_10 (int? eventId, string firstName, string middleName, string lastName, string suffix, string nameStartsWith, string firstNameStartsWith, string middleNameStartsWith, string lastNameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> stories, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'eventId' is set
            if (eventId == null) throw new ApiException(400, "Missing required parameter 'eventId' when calling GetCreatorCollection_10");
    
            var path = "/v1/public/events/{eventId}/creators";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "eventId" + "}", ApiClient.ParameterToString(eventId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (firstName != null) queryParams.Add("firstName", ApiClient.ParameterToString(firstName)); // query parameter
 if (middleName != null) queryParams.Add("middleName", ApiClient.ParameterToString(middleName)); // query parameter
 if (lastName != null) queryParams.Add("lastName", ApiClient.ParameterToString(lastName)); // query parameter
 if (suffix != null) queryParams.Add("suffix", ApiClient.ParameterToString(suffix)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (firstNameStartsWith != null) queryParams.Add("firstNameStartsWith", ApiClient.ParameterToString(firstNameStartsWith)); // query parameter
 if (middleNameStartsWith != null) queryParams.Add("middleNameStartsWith", ApiClient.ParameterToString(middleNameStartsWith)); // query parameter
 if (lastNameStartsWith != null) queryParams.Add("lastNameStartsWith", ApiClient.ParameterToString(lastNameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorCollection_10: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorCollection_10: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of events filtered by a creator id. Fetches lists of events featuring the work of a specific creator with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="creatorId">The creator ID.</param>
        /// <param name="name">Filter the event list by name.</param>
        /// <param name="nameStartsWith">Return events with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only events which have been modified since the specified date.</param>
        /// <param name="characters">Return only events which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only events which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="comics">Return only events which take place in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only events which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetCreatorEventsCollection (int? creatorId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> characters, List<int?> series, List<int?> comics, List<int?> stories, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'creatorId' is set
            if (creatorId == null) throw new ApiException(400, "Missing required parameter 'creatorId' when calling GetCreatorEventsCollection");
    
            var path = "/v1/public/creators/{creatorId}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "creatorId" + "}", ApiClient.ParameterToString(creatorId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorEventsCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorEventsCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches a single creator by id. This method fetches a single creator resource.  It is the canonical URI for any creator resource provided by the API.
        /// </summary>
        /// <param name="creatorId">A single creator id.</param>
        /// <returns></returns>
        public IRestResponse GetCreatorIndividual (int? creatorId)
        {
            // verify the required parameter 'creatorId' is set
            if (creatorId == null) throw new ApiException(400, "Missing required parameter 'creatorId' when calling GetCreatorIndividual");
    
            var path = "/v1/public/creators/{creatorId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "creatorId" + "}", ApiClient.ParameterToString(creatorId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorIndividual: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorIndividual: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of series filtered by a creator id. Fetches lists of comic series in which a specific creator&#x27;s work appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="creatorId">The creator ID.</param>
        /// <param name="title">Filter by series title.</param>
        /// <param name="titleStartsWith">Return series with titles that begin with the specified string (e.g. Sp).</param>
        /// <param name="startYear">Return only series matching the specified start year.</param>
        /// <param name="modifiedSince">Return only series which have been modified since the specified date.</param>
        /// <param name="comics">Return only series which contain the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only series which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only series which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="seriesType">Filter the series by publication frequency type.</param>
        /// <param name="contains">Return only series containing one or more comics with the specified format.</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetCreatorSeriesCollection (int? creatorId, string title, string titleStartsWith, int? startYear, DateTime? modifiedSince, List<int?> comics, List<int?> stories, List<int?> events, List<int?> characters, string seriesType, List<string> contains, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'creatorId' is set
            if (creatorId == null) throw new ApiException(400, "Missing required parameter 'creatorId' when calling GetCreatorSeriesCollection");
    
            var path = "/v1/public/creators/{creatorId}/series";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "creatorId" + "}", ApiClient.ParameterToString(creatorId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (title != null) queryParams.Add("title", ApiClient.ParameterToString(title)); // query parameter
 if (titleStartsWith != null) queryParams.Add("titleStartsWith", ApiClient.ParameterToString(titleStartsWith)); // query parameter
 if (startYear != null) queryParams.Add("startYear", ApiClient.ParameterToString(startYear)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (seriesType != null) queryParams.Add("seriesType", ApiClient.ParameterToString(seriesType)); // query parameter
 if (contains != null) queryParams.Add("contains", ApiClient.ParameterToString(contains)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorSeriesCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorSeriesCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of stories filtered by a creator id. Fetches lists of comic stories by a specific creator with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="creatorId">The ID of the creator.</param>
        /// <param name="modifiedSince">Return only stories which have been modified since the specified date.</param>
        /// <param name="comics">Return only stories contained in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only stories contained the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only stories which take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only stories which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetCreatorStoryCollection (int? creatorId, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<int?> characters, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'creatorId' is set
            if (creatorId == null) throw new ApiException(400, "Missing required parameter 'creatorId' when calling GetCreatorStoryCollection");
    
            var path = "/v1/public/creators/{creatorId}/stories";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "creatorId" + "}", ApiClient.ParameterToString(creatorId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorStoryCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreatorStoryCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of characters filtered by an event id. Fetches lists of characters which appear in a specific event, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="eventId">The event ID</param>
        /// <param name="name">Return only characters matching the specified full character name (e.g. Spider-Man).</param>
        /// <param name="nameStartsWith">Return characters with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only characters which have been modified since the specified date.</param>
        /// <param name="comics">Return only characters which appear in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only characters which appear the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only characters which appear the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetEventCharacterCollection (int? eventId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> stories, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'eventId' is set
            if (eventId == null) throw new ApiException(400, "Missing required parameter 'eventId' when calling GetEventCharacterCollection");
    
            var path = "/v1/public/events/{eventId}/characters";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "eventId" + "}", ApiClient.ParameterToString(eventId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventCharacterCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventCharacterCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches a single event by id. This method fetches a single event resource.  It is the canonical URI for any event resource provided by the API.
        /// </summary>
        /// <param name="eventId">A single event.</param>
        /// <returns></returns>
        public IRestResponse GetEventIndividual (int? eventId)
        {
            // verify the required parameter 'eventId' is set
            if (eventId == null) throw new ApiException(400, "Missing required parameter 'eventId' when calling GetEventIndividual");
    
            var path = "/v1/public/events/{eventId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "eventId" + "}", ApiClient.ParameterToString(eventId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventIndividual: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventIndividual: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of series filtered by an event id. Fetches lists of comic series in which a specific event takes place, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="eventId">The event ID.</param>
        /// <param name="title">Filter by series title.</param>
        /// <param name="titleStartsWith">Return series with titles that begin with the specified string (e.g. Sp).</param>
        /// <param name="startYear">Return only series matching the specified start year.</param>
        /// <param name="modifiedSince">Return only series which have been modified since the specified date.</param>
        /// <param name="comics">Return only series which contain the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only series which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only series which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only series which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="seriesType">Filter the series by publication frequency type.</param>
        /// <param name="contains">Return only series containing one or more comics with the specified format.</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetEventSeriesCollection (int? eventId, string title, string titleStartsWith, int? startYear, DateTime? modifiedSince, List<int?> comics, List<int?> stories, List<int?> creators, List<int?> characters, string seriesType, List<string> contains, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'eventId' is set
            if (eventId == null) throw new ApiException(400, "Missing required parameter 'eventId' when calling GetEventSeriesCollection");
    
            var path = "/v1/public/events/{eventId}/series";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "eventId" + "}", ApiClient.ParameterToString(eventId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (title != null) queryParams.Add("title", ApiClient.ParameterToString(title)); // query parameter
 if (titleStartsWith != null) queryParams.Add("titleStartsWith", ApiClient.ParameterToString(titleStartsWith)); // query parameter
 if (startYear != null) queryParams.Add("startYear", ApiClient.ParameterToString(startYear)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (seriesType != null) queryParams.Add("seriesType", ApiClient.ParameterToString(seriesType)); // query parameter
 if (contains != null) queryParams.Add("contains", ApiClient.ParameterToString(contains)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventSeriesCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventSeriesCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of stories filtered by an event id. Fetches lists of comic stories from a specific event, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="eventId">The ID of the event.</param>
        /// <param name="modifiedSince">Return only stories which have been modified since the specified date.</param>
        /// <param name="comics">Return only stories contained in the specified (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only stories contained the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only stories which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only stories which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetEventStoryCollection (int? eventId, DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> creators, List<int?> characters, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'eventId' is set
            if (eventId == null) throw new ApiException(400, "Missing required parameter 'eventId' when calling GetEventStoryCollection");
    
            var path = "/v1/public/events/{eventId}/stories";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "eventId" + "}", ApiClient.ParameterToString(eventId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventStoryCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventStoryCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of events filtered by a story id. Fetches lists of events in which a specific story appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="storyId">The story ID.</param>
        /// <param name="name">Filter the event list by name.</param>
        /// <param name="nameStartsWith">Return events with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only events which have been modified since the specified date.</param>
        /// <param name="creators">Return only events which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only events which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only events which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="comics">Return only events which take place in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetEventsCollection (int? storyId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> comics, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'storyId' is set
            if (storyId == null) throw new ApiException(400, "Missing required parameter 'storyId' when calling GetEventsCollection");
    
            var path = "/v1/public/stories/{storyId}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "storyId" + "}", ApiClient.ParameterToString(storyId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventsCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventsCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of events filtered by a series id. Fetches lists of events which occur in a specific series, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="seriesId">The series ID.</param>
        /// <param name="name">Filter the event list by name.</param>
        /// <param name="nameStartsWith">Return events with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only events which have been modified since the specified date.</param>
        /// <param name="creators">Return only events which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only events which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="comics">Return only events which take place in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only events which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetEventsCollection_11 (int? seriesId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> comics, List<int?> stories, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'seriesId' is set
            if (seriesId == null) throw new ApiException(400, "Missing required parameter 'seriesId' when calling GetEventsCollection_11");
    
            var path = "/v1/public/series/{seriesId}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "seriesId" + "}", ApiClient.ParameterToString(seriesId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventsCollection_11: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventsCollection_11: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of events. Fetches lists of events with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="name">Return only events which match the specified name.</param>
        /// <param name="nameStartsWith">Return events with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only events which have been modified since the specified date.</param>
        /// <param name="creators">Return only events which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only events which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only events which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="comics">Return only events which take place in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only events which take place in the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetEventsCollection_12 (string name, string nameStartsWith, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> comics, List<int?> stories, List<string> orderBy, int? limit, int? offset)
        {
    
            var path = "/v1/public/events";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventsCollection_12: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventsCollection_12: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of events filtered by a comic id. Fetches lists of events in which a specific comic appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="comicId">The comic ID.</param>
        /// <param name="name">Filter the event list by name.</param>
        /// <param name="nameStartsWith">Return events with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only events which have been modified since the specified date.</param>
        /// <param name="creators">Return only events which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only events which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only events which are part of the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only events which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetIssueEventsCollection (int? comicId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> creators, List<int?> characters, List<int?> series, List<int?> stories, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'comicId' is set
            if (comicId == null) throw new ApiException(400, "Missing required parameter 'comicId' when calling GetIssueEventsCollection");
    
            var path = "/v1/public/comics/{comicId}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "comicId" + "}", ApiClient.ParameterToString(comicId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetIssueEventsCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetIssueEventsCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of characters filtered by a series id. Fetches lists of characters which appear in specific series, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="seriesId">The series id.</param>
        /// <param name="name">Return only characters matching the specified full character name (e.g. Spider-Man).</param>
        /// <param name="nameStartsWith">Return characters with names that begin with the specified string (e.g. Sp).</param>
        /// <param name="modifiedSince">Return only characters which have been modified since the specified date.</param>
        /// <param name="comics">Return only characters which appear in the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only characters which appear the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetSeriesCharacterWrapper (int? seriesId, string name, string nameStartsWith, DateTime? modifiedSince, List<int?> comics, List<int?> events, List<int?> stories, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'seriesId' is set
            if (seriesId == null) throw new ApiException(400, "Missing required parameter 'seriesId' when calling GetSeriesCharacterWrapper");
    
            var path = "/v1/public/series/{seriesId}/characters";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "seriesId" + "}", ApiClient.ParameterToString(seriesId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (nameStartsWith != null) queryParams.Add("nameStartsWith", ApiClient.ParameterToString(nameStartsWith)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSeriesCharacterWrapper: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSeriesCharacterWrapper: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of series. Fetches lists of comic series with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="title">Return only series matching the specified title.</param>
        /// <param name="titleStartsWith">Return series with titles that begin with the specified string (e.g. Sp).</param>
        /// <param name="startYear">Return only series matching the specified start year.</param>
        /// <param name="modifiedSince">Return only series which have been modified since the specified date.</param>
        /// <param name="comics">Return only series which contain the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="stories">Return only series which contain the specified stories (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only series which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only series which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="seriesType">Filter the series by publication frequency type.</param>
        /// <param name="contains">Return only series containing one or more comics with the specified format.</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetSeriesCollection (string title, string titleStartsWith, int? startYear, DateTime? modifiedSince, List<int?> comics, List<int?> stories, List<int?> events, List<int?> creators, List<int?> characters, string seriesType, List<string> contains, List<string> orderBy, int? limit, int? offset)
        {
    
            var path = "/v1/public/series";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (title != null) queryParams.Add("title", ApiClient.ParameterToString(title)); // query parameter
 if (titleStartsWith != null) queryParams.Add("titleStartsWith", ApiClient.ParameterToString(titleStartsWith)); // query parameter
 if (startYear != null) queryParams.Add("startYear", ApiClient.ParameterToString(startYear)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (stories != null) queryParams.Add("stories", ApiClient.ParameterToString(stories)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (seriesType != null) queryParams.Add("seriesType", ApiClient.ParameterToString(seriesType)); // query parameter
 if (contains != null) queryParams.Add("contains", ApiClient.ParameterToString(contains)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSeriesCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSeriesCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches a single comic series by id. This method fetches a single comic series resource.  It is the canonical URI for any comic series resource provided by the API.
        /// </summary>
        /// <param name="seriesId">Filter by series title.</param>
        /// <returns></returns>
        public IRestResponse GetSeriesIndividual (int? seriesId)
        {
            // verify the required parameter 'seriesId' is set
            if (seriesId == null) throw new ApiException(400, "Missing required parameter 'seriesId' when calling GetSeriesIndividual");
    
            var path = "/v1/public/series/{seriesId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "seriesId" + "}", ApiClient.ParameterToString(seriesId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSeriesIndividual: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSeriesIndividual: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of stories filtered by a series id. Fetches lists of comic stories from a specific series with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="seriesId">The series ID.</param>
        /// <param name="modifiedSince">Return only stories which have been modified since the specified date.</param>
        /// <param name="comics">Return only stories contained in the specified (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only stories which take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only stories which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only stories which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetSeriesStoryCollection (int? seriesId, DateTime? modifiedSince, List<int?> comics, List<int?> events, List<int?> creators, List<int?> characters, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'seriesId' is set
            if (seriesId == null) throw new ApiException(400, "Missing required parameter 'seriesId' when calling GetSeriesStoryCollection");
    
            var path = "/v1/public/series/{seriesId}/stories";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "seriesId" + "}", ApiClient.ParameterToString(seriesId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSeriesStoryCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSeriesStoryCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of stories. Fetches lists of comic stories with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="modifiedSince">Return only stories which have been modified since the specified date.</param>
        /// <param name="comics">Return only stories contained in the specified (accepts a comma-separated list of ids).</param>
        /// <param name="series">Return only stories contained the specified series (accepts a comma-separated list of ids).</param>
        /// <param name="events">Return only stories which take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only stories which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only stories which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetStoryCollection (DateTime? modifiedSince, List<int?> comics, List<int?> series, List<int?> events, List<int?> creators, List<int?> characters, List<string> orderBy, int? limit, int? offset)
        {
    
            var path = "/v1/public/stories";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (series != null) queryParams.Add("series", ApiClient.ParameterToString(series)); // query parameter
 if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStoryCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStoryCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches a single comic story by id. This method fetches a single comic story resource.  It is the canonical URI for any comic story resource provided by the API.
        /// </summary>
        /// <param name="storyId">Filter by story id.</param>
        /// <returns></returns>
        public IRestResponse GetStoryIndividual (int? storyId)
        {
            // verify the required parameter 'storyId' is set
            if (storyId == null) throw new ApiException(400, "Missing required parameter 'storyId' when calling GetStoryIndividual");
    
            var path = "/v1/public/stories/{storyId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "storyId" + "}", ApiClient.ParameterToString(storyId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStoryIndividual: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStoryIndividual: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
        /// <summary>
        /// Fetches lists of series filtered by a story id. Fetches lists of comic series in which the specified story takes place. See notes on individual parameters below.
        /// </summary>
        /// <param name="storyId">The story ID.</param>
        /// <param name="events">Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids).</param>
        /// <param name="title">Filter by series title.</param>
        /// <param name="titleStartsWith">Return series with titles that begin with the specified string (e.g. Sp).</param>
        /// <param name="startYear">Return only series matching the specified start year.</param>
        /// <param name="modifiedSince">Return only series which have been modified since the specified date.</param>
        /// <param name="comics">Return only series which contain the specified comics (accepts a comma-separated list of ids).</param>
        /// <param name="creators">Return only series which feature work by the specified creators (accepts a comma-separated list of ids).</param>
        /// <param name="characters">Return only series which feature the specified characters (accepts a comma-separated list of ids).</param>
        /// <param name="seriesType">Filter the series by publication frequency type.</param>
        /// <param name="contains">Return only series containing one or more comics with the specified format.</param>
        /// <param name="orderBy">Order the result set by a field or fields. Add a \&quot;-\&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</param>
        /// <param name="limit">Limit the result set to the specified number of resources.</param>
        /// <param name="offset">Skip the specified number of resources in the result set.</param>
        /// <returns></returns>
        public IRestResponse GetStorySeriesCollection (int? storyId, List<int?> events, string title, string titleStartsWith, int? startYear, DateTime? modifiedSince, List<int?> comics, List<int?> creators, List<int?> characters, string seriesType, List<string> contains, List<string> orderBy, int? limit, int? offset)
        {
            // verify the required parameter 'storyId' is set
            if (storyId == null) throw new ApiException(400, "Missing required parameter 'storyId' when calling GetStorySeriesCollection");
    
            var path = "/v1/public/stories/{storyId}/series";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "storyId" + "}", ApiClient.ParameterToString(storyId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (events != null) queryParams.Add("events", ApiClient.ParameterToString(events)); // query parameter
 if (title != null) queryParams.Add("title", ApiClient.ParameterToString(title)); // query parameter
 if (titleStartsWith != null) queryParams.Add("titleStartsWith", ApiClient.ParameterToString(titleStartsWith)); // query parameter
 if (startYear != null) queryParams.Add("startYear", ApiClient.ParameterToString(startYear)); // query parameter
 if (modifiedSince != null) queryParams.Add("modifiedSince", ApiClient.ParameterToString(modifiedSince)); // query parameter
 if (comics != null) queryParams.Add("comics", ApiClient.ParameterToString(comics)); // query parameter
 if (creators != null) queryParams.Add("creators", ApiClient.ParameterToString(creators)); // query parameter
 if (characters != null) queryParams.Add("characters", ApiClient.ParameterToString(characters)); // query parameter
 if (seriesType != null) queryParams.Add("seriesType", ApiClient.ParameterToString(seriesType)); // query parameter
 if (contains != null) queryParams.Add("contains", ApiClient.ParameterToString(contains)); // query parameter
 if (orderBy != null) queryParams.Add("orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                        
            
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, AuthSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStorySeriesCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStorySeriesCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return response;
        }
    
    }
}

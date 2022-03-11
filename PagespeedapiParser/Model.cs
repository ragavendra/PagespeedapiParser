using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;

namespace PagespeedapiParser
{

    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class LoadingExperience
    {
        public string initial_url { get; set; }
    }

    public class Environment
    {
        public string networkUserAgent { get; set; }
        public string hostUserAgent { get; set; }
        public double benchmarkIndex { get; set; }
    }

    public class ConfigSettings
    {
        public string emulatedFormFactor { get; set; }
        public string formFactor { get; set; }
        public string locale { get; set; }
        public List<string> onlyCategories { get; set; }
        public string channel { get; set; }
    }

    public class Heading
    {
        public string key { get; set; }
        public string itemType { get; set; }
        public string text { get; set; }
        public string label { get; set; }
        public string valueType { get; set; }
        public float? granularity { get; set; }
        public string displayUnit { get; set; }
        public SubItemsHeading subItemsHeading { get; set; }
    }

    public class BoundingRect
    {
        public int bottom { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int right { get; set; }
        public int height { get; set; }
        public int left { get; set; }
    }

    public class Node
    {
        public string nodeLabel { get; set; }
        public string snippet { get; set; }
        public string lhId { get; set; }
        public BoundingRect boundingRect { get; set; }
        public string selector { get; set; }
        public string path { get; set; }
        public string type { get; set; }
    }

    public class Item
    {
        public Node node { get; set; }
        public double responseTime { get; set; }
        public string url { get; set; }
        public double total { get; set; }
        public double scriptParseCompile { get; set; }
        public double scripting { get; set; }
        public DebugData debugData { get; set; }
        public double cacheHitProbability { get; set; }
        public int totalBytes { get; set; }
        public object cacheLifetimeMs { get; set; }
        public double wastedBytes { get; set; }
        public string signal { get; set; }
        public Location location { get; set; }
        public SubItems subItems { get; set; }
        public int mainThreadTime { get; set; }
        public int transferSize { get; set; }
        public int blockingTime { get; set; }
        public Entity entity { get; set; }
        public int wastedWebpBytes { get; set; }
        public bool isCrossOrigin { get; set; }
        public bool fromProtocol { get; set; }
        public double wastedPercent { get; set; }
        public object timestamp { get; set; }
        public int timing { get; set; }
        public string data { get; set; }
        public int wastedMs { get; set; }
        public string statistic { get; set; }
        public int value { get; set; }
        public long observedLoadTs { get; set; }
        public long observedFirstVisualChangeTs { get; set; }
        public int largestContentfulPaint { get; set; }
        public long observedLastVisualChangeTs { get; set; }
        public long observedNavigationStartTs { get; set; }
        public int observedLoad { get; set; }
        public int observedNavigationStart { get; set; }
        public long observedFirstContentfulPaintAllFramesTs { get; set; }
        public double totalCumulativeLayoutShift { get; set; }
        public int firstMeaningfulPaint { get; set; }
        public double cumulativeLayoutShift { get; set; }
        public double observedCumulativeLayoutShiftMainFrame { get; set; }
        public int observedDomContentLoaded { get; set; }
        public int firstContentfulPaint { get; set; }
        public int observedFirstContentfulPaint { get; set; }
        public int observedTimeOrigin { get; set; }
        public long observedLargestContentfulPaintAllFramesTs { get; set; }
        public long observedTimeOriginTs { get; set; }
        public long observedTraceEndTs { get; set; }
        public int observedLargestContentfulPaintAllFrames { get; set; }
        public int observedFirstContentfulPaintAllFrames { get; set; }
        public int maxPotentialFID { get; set; }
        public long observedSpeedIndexTs { get; set; }
        public int observedSpeedIndex { get; set; }
        public long observedDomContentLoadedTs { get; set; }
        public int observedFirstPaint { get; set; }
        public int observedLargestContentfulPaint { get; set; }
        public long observedFirstMeaningfulPaintTs { get; set; }
        public int interactive { get; set; }
        public int totalBlockingTime { get; set; }
        public int speedIndex { get; set; }
        public int observedFirstMeaningfulPaint { get; set; }
        public double observedTotalCumulativeLayoutShift { get; set; }
        public long observedFirstContentfulPaintTs { get; set; }
        public int observedLastVisualChange { get; set; }
        public long observedLargestContentfulPaintTs { get; set; }
        public double cumulativeLayoutShiftMainFrame { get; set; }
        public int observedTraceEnd { get; set; }
        public long observedFirstPaintTs { get; set; }
        public double observedCumulativeLayoutShift { get; set; }
        public int observedFirstVisualChange { get; set; }
        public bool? lcpInvalidated { get; set; }
        public string resourceType { get; set; }
        public int requestCount { get; set; }
        public string label { get; set; }
        public double score { get; set; }
        public bool finished { get; set; }
        public double endTime { get; set; }
        public double startTime { get; set; }
        public int resourceSize { get; set; }
        public string protocol { get; set; }
        public string mimeType { get; set; }
        public int statusCode { get; set; }
        public Source source { get; set; }
        public double duration { get; set; }
        public string groupLabel { get; set; }
        public string group { get; set; }
        public int numStylesheets { get; set; }
        public double maxRtt { get; set; }
        public int numTasksOver25ms { get; set; }
        public double rtt { get; set; }
        public double totalTaskTime { get; set; }
        public double throughput { get; set; }
        public int totalByteWeight { get; set; }
        public int mainDocumentTransferSize { get; set; }
        public int numScripts { get; set; }
        public int numTasksOver10ms { get; set; }
        public int numFonts { get; set; }
        public int numTasksOver50ms { get; set; }
        public object maxServerLatency { get; set; }
        public int numTasks { get; set; }
        public int numTasksOver100ms { get; set; }
        public int numTasksOver500ms { get; set; }
        public int numRequests { get; set; }
    }

    public class Details
    {
        public string type { get; set; }
        public List<Heading> headings { get; set; }
        public List<Item> items { get; set; }
        public double overallSavingsMs { get; set; }
        public Summary summary { get; set; }
        public List<Node> nodes { get; set; }
        public long? overallSavingsBytes { get; set; }
        public Screenshot screenshot { get; set; }
        public int scale { get; set; }
        public long timestamp { get; set; }
        public string data { get; set; }
        public int timing { get; set; }
        public LongestChain longestChain { get; set; }
        public Chains chains { get; set; }
    }

    public class LargestContentfulPaintElement
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
    }

    public class Interactive
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class ServerResponseTime
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public double numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Summary
    {
        public double wastedMs { get; set; }
        public double wastedBytes { get; set; }
    }

    public class BootupTime
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public double numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class DebugData
    {
        public string type { get; set; }

        //[JsonPropertyNameName("test")]
        [JsonPropertyName("max-age")]
        public int MaxAge { get; set; }
    }

    public class UsesLongCacheTtl
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public double numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class TimingBudget
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
    }

    public class ScriptTreemapData
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
    }

    public class DuplicatedJavascript
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class UsesTextCompression
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class SubItemsHeading
    {
        public string key { get; set; }
        public string valueType { get; set; }
        public string itemType { get; set; }
    }

    public class Location
    {
        public int line { get; set; }
        public int column { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public string urlProvider { get; set; }
    }

    public class SubItems
    {
        public string type { get; set; }
        public List<Item> items { get; set; }
    }

    public class LegacyJavascript
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class PerformanceBudget
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
    }

    public class UnsizedImages
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
    }

    public class UsesOptimizedImages
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
        public List<object> warnings { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Screenshot
    {
        public string data { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }

    public class FullPageScreenshot
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public object? details { get; set; }
    }

    public class NonCompositedAnimations
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
    }

    public class Entity
    {
        public string text { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class ThirdPartySummary
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
    }

    public class EfficientAnimatedContent
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class ModernImageFormats
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public List<object> warnings { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class NetworkRtt
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class LongTasks
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
    }

    public class UnminifiedCss
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class FirstContentfulPaint
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public double numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class UsesRelPreconnect
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
        public List<object> warnings { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class TotalBlockingTime
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class ScreenshotThumbnails
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
    }

    public class FirstMeaningfulPaint
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class UserTimings
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
    }

    public class UnusedJavascript
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class PreloadLcpImage
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class UsesResponsiveImages
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class FontDisplay
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
        public List<object> warnings { get; set; }
    }

    public class LcpLazyLoaded
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
    }

    public class DomSize
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class NoDocumentWrite
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
    }

    public class RenderBlockingResources
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Metrics
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class LargestContentfulPaint
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class ResourceSummary
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
    }

    public class FinalScreenshot
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
    }

    public class ThirdPartyFacades
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
    }

    public class LongestChain
    {
        public int transferSize { get; set; }
        public int length { get; set; }
        public double duration { get; set; }
    }

    public class Request
    {
        public double responseReceivedTime { get; set; }
        public string url { get; set; }
        public double startTime { get; set; }
        public double endTime { get; set; }
        public int transferSize { get; set; }
    }

    public class _405
    {
        public Request request { get; set; }
    }

    public class _409
    {
        public Request request { get; set; }
    }

    public class _404
    {
        public Request request { get; set; }
    }

    public class _4031
    {
        public Request request { get; set; }
    }

    public class _406
    {
        public Request request { get; set; }
    }

    public class _408
    {
        public Request request { get; set; }
    }

    public class _4060
    {
        public Request request { get; set; }
    }

    public class Children2
    {
        [JsonPropertyName("40.60")]
        public _4060 _4060 { get; set; }

        [JsonPropertyName("40.53")]
        public _4053 _4053 { get; set; }

        [JsonPropertyName("40.50")]
        public _4050 _4050 { get; set; }

        [JsonPropertyName("40.47")]
        public _4047 _4047 { get; set; }

        [JsonPropertyName("40.74")]
        public _4074 _4074 { get; set; }

        [JsonPropertyName("40.77")]
        public _4077 _4077 { get; set; }

        [JsonPropertyName("40.5")]
        public _405 _405 { get; set; }

        [JsonPropertyName("40.9")]
        public _409 _409 { get; set; }

        [JsonPropertyName("40.4")]
        public _404 _404 { get; set; }

        [JsonPropertyName("40.31")]
        public _4031 _4031 { get; set; }

        [JsonPropertyName("40.6")]
        public _406 _406 { get; set; }

        [JsonPropertyName("40.8")]
        public _408 _408 { get; set; }

        [JsonPropertyName("40.7")]
        public _407 _407 { get; set; }

        [JsonPropertyName("40.3")]
        public _403 _403 { get; set; }

        [JsonPropertyName("40.30")]
        public _4030 _4030 { get; set; }

        [JsonPropertyName("40.10")]
        public _4010 _4010 { get; set; }
    }

    public class _407
    {
        public Request request { get; set; }
        public Children children { get; set; }
    }

    public class Request1
    {
        public double startTime { get; set; }
        public int transferSize { get; set; }
        public string url { get; set; }
        public double responseReceivedTime { get; set; }
        public double endTime { get; set; }
    }

    public class Children
    {
        [JsonPropertyName("40.60")]
        public _4060 _4060 { get; set; }
    }

    public class _4053
    {
        public Request request { get; set; }
    }

    public class _4050
    {
        public Request request { get; set; }
    }

    public class _4047
    {
        public Request request { get; set; }
    }

    public class _403
    {
        public Request request { get; set; }
        public Children children { get; set; }
    }

    public class _4074
    {
        public Request request { get; set; }
    }

    public class _4077
    {
        public Request request { get; set; }
    }

    public class _4030
    {
        public Children children { get; set; }
        public Request request { get; set; }
    }

    public class _4010
    {
        public Request request { get; set; }
    }

    public class D6185C894E8A78B7DC2D6B0B1A50F5F3
    {
        public Children children { get; set; }
        public Request request { get; set; }
    }

    public class Chains
    {
        public D6185C894E8A78B7DC2D6B0B1A50F5F3 D6185C894E8A78B7DC2D6B0B1A50F5F3 { get; set; }
    }

    public class CriticalRequestChains
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
    }

    public class NoUnloadListeners
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
    }

    public class LayoutShiftElements
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
    }

    public class NetworkRequests
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
    }

    public class Viewport
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public List<object> warnings { get; set; }
    }

    public class TotalByteWeight
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class NetworkServerLatency
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Source
    {
        public string type { get; set; }
        public string url { get; set; }
        public int column { get; set; }
        public string urlProvider { get; set; }
        public int line { get; set; }
    }

    public class UsesPassiveEventListeners
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
    }

    public class UnusedCssRules
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class SpeedIndex
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public double numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class CumulativeLayoutShift
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public double numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class MaxPotentialFid
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class OffscreenImages
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
        public List<object> warnings { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class UsesRelPreload
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
    }

    public class Redirects
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class MainthreadWorkBreakdown
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public double numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class MainThreadTasks
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
    }

    public class UnminifiedJavascript
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details details { get; set; }
        public List<object> warnings { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Diagnostics
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details details { get; set; }
    }

    public class Audits
    {
        [JsonPropertyName("largest-contentful-paint-element")]
        public LargestContentfulPaintElement LargestContentfulPaintElement { get; set; }
        public Interactive interactive { get; set; }

        [JsonPropertyName("server-response-time")]
        public ServerResponseTime ServerResponseTime { get; set; }

        [JsonPropertyName("bootup-time")]
        public BootupTime BootupTime { get; set; }

        [JsonPropertyName("uses-long-cache-ttl")]
        public UsesLongCacheTtl UsesLongCacheTtl { get; set; }

        [JsonPropertyName("timing-budget")]
        public TimingBudget TimingBudget { get; set; }

        [JsonPropertyName("script-treemap-data")]
        public ScriptTreemapData ScriptTreemapData { get; set; }

        [JsonPropertyName("duplicated-javascript")]
        public DuplicatedJavascript DuplicatedJavascript { get; set; }

        [JsonPropertyName("uses-text-compression")]
        public UsesTextCompression UsesTextCompression { get; set; }

        [JsonPropertyName("legacy-javascript")]
        public LegacyJavascript LegacyJavascript { get; set; }

        [JsonPropertyName("performance-budget")]
        public PerformanceBudget PerformanceBudget { get; set; }

        [JsonPropertyName("unsized-images")]
        public UnsizedImages UnsizedImages { get; set; }

        [JsonPropertyName("uses-optimized-images")]
        public UsesOptimizedImages UsesOptimizedImages { get; set; }

        [JsonPropertyName("full-page-screenshot")]
        public FullPageScreenshot FullPageScreenshot { get; set; }

        [JsonPropertyName("non-composited-animations")]
        public NonCompositedAnimations NonCompositedAnimations { get; set; }

        [JsonPropertyName("third-party-summary")]
        public ThirdPartySummary ThirdPartySummary { get; set; }

        [JsonPropertyName("efficient-animated-content")]
        public EfficientAnimatedContent EfficientAnimatedContent { get; set; }

        [JsonPropertyName("modern-image-formats")]
        public ModernImageFormats ModernImageFormats { get; set; }

        [JsonPropertyName("network-rtt")]
        public NetworkRtt NetworkRtt { get; set; }

        [JsonPropertyName("long-tasks")]
        public LongTasks LongTasks { get; set; }

        [JsonPropertyName("unminified-css")]
        public UnminifiedCss UnminifiedCss { get; set; }

        [JsonPropertyName("first-contentful-paint")]
        public FirstContentfulPaint FirstContentfulPaint { get; set; }

        [JsonPropertyName("uses-rel-preconnect")]
        public UsesRelPreconnect UsesRelPreconnect { get; set; }

        [JsonPropertyName("total-blocking-time")]
        public TotalBlockingTime TotalBlockingTime { get; set; }

        [JsonPropertyName("screenshot-thumbnails")]
        public ScreenshotThumbnails ScreenshotThumbnails { get; set; }

        [JsonPropertyName("first-meaningful-paint")]
        public FirstMeaningfulPaint FirstMeaningfulPaint { get; set; }

        [JsonPropertyName("user-timings")]
        public UserTimings UserTimings { get; set; }

        [JsonPropertyName("unused-javascript")]
        public UnusedJavascript UnusedJavascript { get; set; }

        [JsonPropertyName("preload-lcp-image")]
        public PreloadLcpImage PreloadLcpImage { get; set; }

        [JsonPropertyName("uses-responsive-images")]
        public UsesResponsiveImages UsesResponsiveImages { get; set; }

        [JsonPropertyName("font-display")]
        public FontDisplay FontDisplay { get; set; }

        [JsonPropertyName("lcp-lazy-loaded")]
        public LcpLazyLoaded LcpLazyLoaded { get; set; }

        [JsonPropertyName("dom-size")]
        public DomSize DomSize { get; set; }

        [JsonPropertyName("no-document-write")]
        public NoDocumentWrite NoDocumentWrite { get; set; }

        [JsonPropertyName("render-blocking-resources")]
        public RenderBlockingResources RenderBlockingResources { get; set; }
        public Metrics metrics { get; set; }

        [JsonPropertyName("largest-contentful-paint")]
        public LargestContentfulPaint LargestContentfulPaint { get; set; }

        [JsonPropertyName("resource-summary")]
        public ResourceSummary ResourceSummary { get; set; }

        [JsonPropertyName("final-screenshot")]
        public FinalScreenshot FinalScreenshot { get; set; }

        [JsonPropertyName("third-party-facades")]
        public ThirdPartyFacades ThirdPartyFacades { get; set; }

        [JsonPropertyName("critical-request-chains")]
        public CriticalRequestChains CriticalRequestChains { get; set; }

        [JsonPropertyName("no-unload-listeners")]
        public NoUnloadListeners NoUnloadListeners { get; set; }

        [JsonPropertyName("layout-shift-elements")]
        public LayoutShiftElements LayoutShiftElements { get; set; }

        [JsonPropertyName("network-requests")]
        public NetworkRequests NetworkRequests { get; set; }
        public Viewport viewport { get; set; }

        [JsonPropertyName("total-byte-weight")]
        public TotalByteWeight TotalByteWeight { get; set; }

        [JsonPropertyName("network-server-latency")]
        public NetworkServerLatency NetworkServerLatency { get; set; }

        [JsonPropertyName("uses-passive-event-listeners")]
        public UsesPassiveEventListeners UsesPassiveEventListeners { get; set; }

        [JsonPropertyName("unused-css-rules")]
        public UnusedCssRules UnusedCssRules { get; set; }

        [JsonPropertyName("speed-index")]
        public SpeedIndex SpeedIndex { get; set; }

        [JsonPropertyName("cumulative-layout-shift")]
        public CumulativeLayoutShift CumulativeLayoutShift { get; set; }

        [JsonPropertyName("max-potential-fid")]
        public MaxPotentialFid MaxPotentialFid { get; set; }

        [JsonPropertyName("offscreen-images")]
        public OffscreenImages OffscreenImages { get; set; }

        [JsonPropertyName("uses-rel-preload")]
        public UsesRelPreload UsesRelPreload { get; set; }
        public Redirects redirects { get; set; }

        [JsonPropertyName("mainthread-work-breakdown")]
        public MainthreadWorkBreakdown MainthreadWorkBreakdown { get; set; }

        [JsonPropertyName("main-thread-tasks")]
        public MainThreadTasks MainThreadTasks { get; set; }

        [JsonPropertyName("unminified-javascript")]
        public UnminifiedJavascript UnminifiedJavascript { get; set; }
        public Diagnostics diagnostics { get; set; }
    }

    public class AuditRef
    {
        public string id { get; set; }
        public int weight { get; set; }
        public string group { get; set; }
        public string acronym { get; set; }
        public List<string> relevantAudits { get; set; }
    }

    public class Performance
    {
        public string id { get; set; }
        public string title { get; set; }
        public double score { get; set; }
        public List<AuditRef> auditRefs { get; set; }
    }

    public class Categories
    {
        public Performance performance { get; set; }
    }

    public class BestPracticesTrustSafety
    {
        public string title { get; set; }
    }

    public class SeoContent
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class A11yLanguage
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class BestPracticesBrowserCompat
    {
        public string title { get; set; }
    }

    public class A11yTablesLists
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class SeoCrawl
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class A11yAria
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class A11yBestPractices
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class Budgets
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class A11yNavigation
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class PwaOptimized
    {
        public string title { get; set; }
    }

    public class PwaInstallable
    {
        public string title { get; set; }
    }

    public class BestPracticesGeneral
    {
        public string title { get; set; }
    }

    public class A11yNamesLabels
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class A11yAudioVideo
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class BestPracticesUx
    {
        public string title { get; set; }
    }

    public class A11yColorContrast
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class SeoMobile
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class LoadOpportunities
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class CategoryGroups
    {
        [JsonPropertyName("best-practices-trust-safety")]
        public BestPracticesTrustSafety BestPracticesTrustSafety { get; set; }

        [JsonPropertyName("seo-content")]
        public SeoContent SeoContent { get; set; }

        [JsonPropertyName("a11y-language")]
        public A11yLanguage A11yLanguage { get; set; }

        [JsonPropertyName("best-practices-browser-compat")]
        public BestPracticesBrowserCompat BestPracticesBrowserCompat { get; set; }

        [JsonPropertyName("a11y-tables-lists")]
        public A11yTablesLists A11yTablesLists { get; set; }

        [JsonPropertyName("seo-crawl")]
        public SeoCrawl SeoCrawl { get; set; }

        [JsonPropertyName("a11y-aria")]
        public A11yAria A11yAria { get; set; }

        [JsonPropertyName("a11y-best-practices")]
        public A11yBestPractices A11yBestPractices { get; set; }
        public Budgets budgets { get; set; }

        [JsonPropertyName("a11y-navigation")]
        public A11yNavigation A11yNavigation { get; set; }

        [JsonPropertyName("pwa-optimized")]
        public PwaOptimized PwaOptimized { get; set; }

        [JsonPropertyName("pwa-installable")]
        public PwaInstallable PwaInstallable { get; set; }

        [JsonPropertyName("best-practices-general")]
        public BestPracticesGeneral BestPracticesGeneral { get; set; }

        [JsonPropertyName("a11y-names-labels")]
        public A11yNamesLabels A11yNamesLabels { get; set; }

        [JsonPropertyName("a11y-audio-video")]
        public A11yAudioVideo A11yAudioVideo { get; set; }

        [JsonPropertyName("best-practices-ux")]
        public BestPracticesUx BestPracticesUx { get; set; }

        [JsonPropertyName("a11y-color-contrast")]
        public A11yColorContrast A11yColorContrast { get; set; }
        public Diagnostics diagnostics { get; set; }
        public Metrics metrics { get; set; }

        [JsonPropertyName("seo-mobile")]
        public SeoMobile SeoMobile { get; set; }

        [JsonPropertyName("load-opportunities")]
        public LoadOpportunities LoadOpportunities { get; set; }
    }

    public class Timing
    {
        public double total { get; set; }
    }

    public class RendererFormattedStrings
    {
        public string varianceDisclaimer { get; set; }
        public string opportunityResourceColumnLabel { get; set; }
        public string opportunitySavingsColumnLabel { get; set; }
        public string errorMissingAuditInfo { get; set; }
        public string errorLabel { get; set; }
        public string warningHeader { get; set; }
        public string passedAuditsGroupTitle { get; set; }
        public string notApplicableAuditsGroupTitle { get; set; }
        public string manualAuditsGroupTitle { get; set; }
        public string toplevelWarningsMessage { get; set; }
        public string crcLongestDurationLabel { get; set; }
        public string crcInitialNavigation { get; set; }
        public string lsPerformanceCategoryDescription { get; set; }
        public string labDataTitle { get; set; }
        public string warningAuditsGroupTitle { get; set; }
        public string snippetExpandButtonLabel { get; set; }
        public string snippetCollapseButtonLabel { get; set; }
        public string thirdPartyResourcesLabel { get; set; }
        public string runtimeDesktopEmulation { get; set; }
        public string runtimeMobileEmulation { get; set; }
        public string runtimeNoEmulation { get; set; }
        public string runtimeSettingsBenchmark { get; set; }
        public string runtimeSettingsCPUThrottling { get; set; }
        public string runtimeSettingsDevice { get; set; }
        public string runtimeSettingsNetworkThrottling { get; set; }
        public string runtimeSettingsUANetwork { get; set; }
        public string runtimeUnknown { get; set; }
        public string dropdownCopyJSON { get; set; }
        public string dropdownDarkTheme { get; set; }
        public string dropdownPrintExpanded { get; set; }
        public string dropdownPrintSummary { get; set; }
        public string dropdownSaveGist { get; set; }
        public string dropdownSaveHTML { get; set; }
        public string dropdownSaveJSON { get; set; }
        public string dropdownViewer { get; set; }
        public string footerIssue { get; set; }
        public string throttlingProvided { get; set; }
        public string calculatorLink { get; set; }
        public string runtimeSettingsAxeVersion { get; set; }
        public string viewTreemapLabel { get; set; }
        public string showRelevantAudits { get; set; }
    }

    public class I18n
    {
        public RendererFormattedStrings rendererFormattedStrings { get; set; }
    }

    public class Descriptions
    {
        [JsonPropertyName("server-response-time")]
        public string ServerResponseTime { get; set; }

        [JsonPropertyName("uses-optimized-images")]
        public string UsesOptimizedImages { get; set; }

        [JsonPropertyName("unminified-javascript")]
        public string UnminifiedJavascript { get; set; }

        [JsonPropertyName("unminified-css")]
        public string UnminifiedCss { get; set; }

        [JsonPropertyName("unused-css-rules")]
        public string UnusedCssRules { get; set; }

        [JsonPropertyName("render-blocking-resources")]
        public string RenderBlockingResources { get; set; }

        [JsonPropertyName("efficient-animated-content")]
        public string EfficientAnimatedContent { get; set; }

        [JsonPropertyName("uses-long-cache-ttl")]
        public string UsesLongCacheTtl { get; set; }

        [JsonPropertyName("total-byte-weight")]
        public string TotalByteWeight { get; set; }

        [JsonPropertyName("uses-text-compression")]
        public string UsesTextCompression { get; set; }

        [JsonPropertyName("offscreen-images")]
        public string OffscreenImages { get; set; }

        [JsonPropertyName("modern-image-formats")]
        public string ModernImageFormats { get; set; }

        [JsonPropertyName("uses-responsive-images")]
        public string UsesResponsiveImages { get; set; }

        [JsonPropertyName("unused-javascript")]
        public string UnusedJavascript { get; set; }
    }

    public class StackPack
    {
        public string id { get; set; }
        public string title { get; set; }
        public string iconDataURL { get; set; }
        public Descriptions descriptions { get; set; }
    }

    public class LighthouseResult
    {
        public string requestedUrl { get; set; }
        public string finalUrl { get; set; }
        public string lighthouseVersion { get; set; }
        public string userAgent { get; set; }
        public DateTime fetchTime { get; set; }
        public Environment environment { get; set; }
        public List<object> runWarnings { get; set; }
        public ConfigSettings configSettings { get; set; }
        public Audits audits { get; set; }
        public Categories categories { get; set; }
        public CategoryGroups categoryGroups { get; set; }
        public Timing timing { get; set; }
        public I18n i18n { get; set; }
        public List<StackPack> stackPacks { get; set; }
    }

    public class Model
    {
        public string captchaResult { get; set; }
        public string kind { get; set; }
        public string id { get; set; }
        public LoadingExperience loadingExperience { get; set; }
        public LighthouseResult lighthouseResult { get; set; }
        public DateTime analysisUTCTimestamp { get; set; }
    }


}
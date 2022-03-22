namespace PagespeedapiParser
{

    public class Model
    {
        public string captchaResult { get; set; }
        public string kind { get; set; }
        public string id { get; set; }
        public Loadingexperience loadingExperience { get; set; }
        public Originloadingexperience originLoadingExperience { get; set; }
        public Lighthouseresult lighthouseResult { get; set; }
        public DateTime analysisUTCTimestamp { get; set; }
    }

    public class Loadingexperience
    {
        public string id { get; set; }
        public Metrics metrics { get; set; }
        public string overall_category { get; set; }
        public string initial_url { get; set; }
    }

    public class Metrics
    {
        public CUMULATIVE_LAYOUT_SHIFT_SCORE CUMULATIVE_LAYOUT_SHIFT_SCORE { get; set; }
        public FIRST_CONTENTFUL_PAINT_MS FIRST_CONTENTFUL_PAINT_MS { get; set; }
        public FIRST_INPUT_DELAY_MS FIRST_INPUT_DELAY_MS { get; set; }
        public LARGEST_CONTENTFUL_PAINT_MS LARGEST_CONTENTFUL_PAINT_MS { get; set; }
    }

    public class CUMULATIVE_LAYOUT_SHIFT_SCORE
    {
        public int percentile { get; set; }
        public Distribution[] distributions { get; set; }
        public string category { get; set; }
    }

    public class Distribution
    {
        public int min { get; set; }
        public int max { get; set; }
        public float proportion { get; set; }
    }

    public class FIRST_CONTENTFUL_PAINT_MS
    {
        public int percentile { get; set; }
        public Distribution1[] distributions { get; set; }
        public string category { get; set; }
    }

    public class Distribution1
    {
        public int min { get; set; }
        public int max { get; set; }
        public float proportion { get; set; }
    }

    public class FIRST_INPUT_DELAY_MS
    {
        public int percentile { get; set; }
        public Distribution2[] distributions { get; set; }
        public string category { get; set; }
    }

    public class Distribution2
    {
        public int min { get; set; }
        public int max { get; set; }
        public float proportion { get; set; }
    }

    public class LARGEST_CONTENTFUL_PAINT_MS
    {
        public int percentile { get; set; }
        public Distribution3[] distributions { get; set; }
        public string category { get; set; }
    }

    public class Distribution3
    {
        public int min { get; set; }
        public int max { get; set; }
        public float proportion { get; set; }
    }

    public class Originloadingexperience
    {
        public string id { get; set; }
        public Metrics1 metrics { get; set; }
        public string overall_category { get; set; }
        public string initial_url { get; set; }
    }

    public class Metrics1
    {
        public CUMULATIVE_LAYOUT_SHIFT_SCORE1 CUMULATIVE_LAYOUT_SHIFT_SCORE { get; set; }
        public FIRST_CONTENTFUL_PAINT_MS1 FIRST_CONTENTFUL_PAINT_MS { get; set; }
        public FIRST_INPUT_DELAY_MS1 FIRST_INPUT_DELAY_MS { get; set; }
        public LARGEST_CONTENTFUL_PAINT_MS1 LARGEST_CONTENTFUL_PAINT_MS { get; set; }
    }

    public class CUMULATIVE_LAYOUT_SHIFT_SCORE1
    {
        public int percentile { get; set; }
        public Distribution4[] distributions { get; set; }
        public string category { get; set; }
    }

    public class Distribution4
    {
        public int min { get; set; }
        public int max { get; set; }
        public float proportion { get; set; }
    }

    public class FIRST_CONTENTFUL_PAINT_MS1
    {
        public int percentile { get; set; }
        public Distribution5[] distributions { get; set; }
        public string category { get; set; }
    }

    public class Distribution5
    {
        public int min { get; set; }
        public int max { get; set; }
        public float proportion { get; set; }
    }

    public class FIRST_INPUT_DELAY_MS1
    {
        public int percentile { get; set; }
        public Distribution6[] distributions { get; set; }
        public string category { get; set; }
    }

    public class Distribution6
    {
        public int min { get; set; }
        public int max { get; set; }
        public float proportion { get; set; }
    }

    public class LARGEST_CONTENTFUL_PAINT_MS1
    {
        public int percentile { get; set; }
        public Distribution7[] distributions { get; set; }
        public string category { get; set; }
    }

    public class Distribution7
    {
        public int min { get; set; }
        public int max { get; set; }
        public float proportion { get; set; }
    }

    public class Lighthouseresult
    {
        public string requestedUrl { get; set; }
        public string finalUrl { get; set; }
        public string lighthouseVersion { get; set; }
        public string userAgent { get; set; }
        public DateTime fetchTime { get; set; }
        public Environment environment { get; set; }
        public string[] runWarnings { get; set; }
        public Configsettings configSettings { get; set; }
        public Audits audits { get; set; }
        public Categories categories { get; set; }
        public Categorygroups categoryGroups { get; set; }
        public Timing timing { get; set; }
        public I18n i18n { get; set; }
    }

    public class Environment
    {
        public string networkUserAgent { get; set; }
        public string hostUserAgent { get; set; }
        public int benchmarkIndex { get; set; }
    }

    public class Configsettings
    {
        public string emulatedFormFactor { get; set; }
        public string formFactor { get; set; }
        public string locale { get; set; }
        public string[] onlyCategories { get; set; }
        public string channel { get; set; }
    }

    public class Audits
    {
        public UnminifiedCss unminifiedcss { get; set; }
        public RenderBlockingResources renderblockingresources { get; set; }
        public ServerResponseTime serverresponsetime { get; set; }
        public Metrics2 metrics { get; set; }
        public UsesRelPreconnect usesrelpreconnect { get; set; }
        public ModernImageFormats modernimageformats { get; set; }
        public SpeedIndex speedindex { get; set; }
        public UsesRelPreload usesrelpreload { get; set; }
        public ThirdPartySummary thirdpartysummary { get; set; }
        public OffscreenImages offscreenimages { get; set; }
        public Interactive interactive { get; set; }
        public FinalScreenshot finalscreenshot { get; set; }
        public LargestContentfulPaintElement largestcontentfulpaintelement { get; set; }
        public ScriptTreemapData scripttreemapdata { get; set; }
        public LayoutShiftElements layoutshiftelements { get; set; }
        public UsesLongCacheTtl useslongcachettl { get; set; }
        public DomSize domsize { get; set; }
        public UsesTextCompression usestextcompression { get; set; }
        public LongTasks longtasks { get; set; }
        public MaxPotentialFid maxpotentialfid { get; set; }
        public UnsizedImages unsizedimages { get; set; }
        public ResourceSummary resourcesummary { get; set; }
        public FirstMeaningfulPaint firstmeaningfulpaint { get; set; }
        public NonCompositedAnimations noncompositedanimations { get; set; }
        public UsesOptimizedImages usesoptimizedimages { get; set; }
        public NetworkServerLatency networkserverlatency { get; set; }
        public UserTimings usertimings { get; set; }
        public LcpLazyLoaded lcplazyloaded { get; set; }
        public UnusedCssRules unusedcssrules { get; set; }
        public TotalBlockingTime totalblockingtime { get; set; }
        public Redirects redirects { get; set; }
        public UsesResponsiveImages usesresponsiveimages { get; set; }
        public FullPageScreenshot fullpagescreenshot { get; set; }
        public NetworkRequests networkrequests { get; set; }
        public TotalByteWeight totalbyteweight { get; set; }
        public FirstContentfulPaint firstcontentfulpaint { get; set; }
        public UnusedJavascript unusedjavascript { get; set; }
        public FontDisplay fontdisplay { get; set; }
        public UnminifiedJavascript unminifiedjavascript { get; set; }
        public NoUnloadListeners nounloadlisteners { get; set; }
        public NetworkRtt networkrtt { get; set; }
        public LargestContentfulPaint largestcontentfulpaint { get; set; }
        public LegacyJavascript legacyjavascript { get; set; }
        public DuplicatedJavascript duplicatedjavascript { get; set; }
        public Diagnostics diagnostics { get; set; }
        public TimingBudget timingbudget { get; set; }
        public MainThreadTasks mainthreadtasks { get; set; }
        public ScreenshotThumbnails screenshotthumbnails { get; set; }
        public PerformanceBudget performancebudget { get; set; }
        public NoDocumentWrite nodocumentwrite { get; set; }
        public EfficientAnimatedContent efficientanimatedcontent { get; set; }
        public UsesPassiveEventListeners usespassiveeventlisteners { get; set; }
        public MainthreadWorkBreakdown mainthreadworkbreakdown { get; set; }
        public CumulativeLayoutShift cumulativelayoutshift { get; set; }
        public Viewport viewport { get; set; }
        public BootupTime bootuptime { get; set; }
        public CriticalRequestChains criticalrequestchains { get; set; }
        public PreloadLcpImage preloadlcpimage { get; set; }
        public ThirdPartyFacades thirdpartyfacades { get; set; }
    }

    public class UnminifiedCss
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

    public class Details
    {
        public int overallSavingsMs { get; set; }
        public int overallSavingsBytes { get; set; }
        public object[] items { get; set; }
        public string type { get; set; }
        public object[] headings { get; set; }
    }

    public class RenderBlockingResources
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details1 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details1
    {
        public string type { get; set; }
        public object[] items { get; set; }
        public object[] headings { get; set; }
        public int overallSavingsMs { get; set; }
    }

    public class ServerResponseTime
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details2 details { get; set; }
        public float numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details2
    {
        public string type { get; set; }
        public float overallSavingsMs { get; set; }
        public Item[] items { get; set; }
        public Heading[] headings { get; set; }
    }

    public class Item
    {
        public string url { get; set; }
        public float responseTime { get; set; }
    }

    public class Heading
    {
        public string valueType { get; set; }
        public string key { get; set; }
        public string label { get; set; }
    }

    public class Metrics2
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details3 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details3
    {
        public Item1[] items { get; set; }
        public string type { get; set; }
    }

    public class Item1
    {
        public int observedFirstPaint { get; set; }
        public long observedTraceEndTs { get; set; }
        public long observedFirstVisualChangeTs { get; set; }
        public int observedLargestContentfulPaint { get; set; }
        public int maxPotentialFID { get; set; }
        public int cumulativeLayoutShiftMainFrame { get; set; }
        public int observedFirstMeaningfulPaint { get; set; }
        public int observedTimeOrigin { get; set; }
        public int observedCumulativeLayoutShiftMainFrame { get; set; }
        public int observedSpeedIndex { get; set; }
        public int observedLoad { get; set; }
        public long observedFirstMeaningfulPaintTs { get; set; }
        public int observedTotalCumulativeLayoutShift { get; set; }
        public int observedTraceEnd { get; set; }
        public long observedLargestContentfulPaintAllFramesTs { get; set; }
        public int observedFirstContentfulPaintAllFrames { get; set; }
        public long observedFirstContentfulPaintAllFramesTs { get; set; }
        public long observedFirstContentfulPaintTs { get; set; }
        public int totalBlockingTime { get; set; }
        public int observedCumulativeLayoutShift { get; set; }
        public int totalCumulativeLayoutShift { get; set; }
        public int observedLastVisualChange { get; set; }
        public int observedLargestContentfulPaintAllFrames { get; set; }
        public int largestContentfulPaint { get; set; }
        public int cumulativeLayoutShift { get; set; }
        public int speedIndex { get; set; }
        public long observedNavigationStartTs { get; set; }
        public int interactive { get; set; }
        public long observedTimeOriginTs { get; set; }
        public long observedLargestContentfulPaintTs { get; set; }
        public int observedFirstContentfulPaint { get; set; }
        public int observedDomContentLoaded { get; set; }
        public long observedFirstPaintTs { get; set; }
        public long observedLoadTs { get; set; }
        public long observedLastVisualChangeTs { get; set; }
        public long observedDomContentLoadedTs { get; set; }
        public int observedFirstVisualChange { get; set; }
        public long observedSpeedIndexTs { get; set; }
        public int firstMeaningfulPaint { get; set; }
        public int firstContentfulPaint { get; set; }
        public int observedNavigationStart { get; set; }
        public bool lcpInvalidated { get; set; }
    }

    public class UsesRelPreconnect
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details4 details { get; set; }
        public object[] warnings { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details4
    {
        public object[] items { get; set; }
        public object[] headings { get; set; }
        public string type { get; set; }
        public int overallSavingsMs { get; set; }
    }

    public class ModernImageFormats
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details5 details { get; set; }
        public object[] warnings { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details5
    {
        public string type { get; set; }
        public object[] items { get; set; }
        public int overallSavingsBytes { get; set; }
        public object[] headings { get; set; }
        public int overallSavingsMs { get; set; }
    }

    public class SpeedIndex
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public float numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class UsesRelPreload
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details6 details { get; set; }
    }

    public class Details6
    {
        public object[] items { get; set; }
        public string type { get; set; }
        public object[] headings { get; set; }
        public int overallSavingsMs { get; set; }
    }

    public class ThirdPartySummary
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details7 details { get; set; }
    }

    public class Details7
    {
        public Heading1[] headings { get; set; }
        public string type { get; set; }
        public Item2[] items { get; set; }
        public Summary summary { get; set; }
    }

    public class Summary
    {
        public int wastedBytes { get; set; }
        public int wastedMs { get; set; }
    }

    public class Heading1
    {
        public string itemType { get; set; }
        public string text { get; set; }
        public Subitemsheading subItemsHeading { get; set; }
        public string key { get; set; }
        public int granularity { get; set; }
    }

    public class Subitemsheading
    {
        public string key { get; set; }
        public string itemType { get; set; }
    }

    public class Item2
    {
        public Entity entity { get; set; }
        public Subitems subItems { get; set; }
        public float mainThreadTime { get; set; }
        public int transferSize { get; set; }
        public int blockingTime { get; set; }
    }

    public class Entity
    {
        public string text { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Subitems
    {
        public string type { get; set; }
        public Item3[] items { get; set; }
    }

    public class Item3
    {
        public float mainThreadTime { get; set; }
        public string url { get; set; }
        public int blockingTime { get; set; }
        public int transferSize { get; set; }
    }

    public class OffscreenImages
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details8 details { get; set; }
        public object[] warnings { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details8
    {
        public int overallSavingsBytes { get; set; }
        public int overallSavingsMs { get; set; }
        public string type { get; set; }
        public object[] headings { get; set; }
        public object[] items { get; set; }
    }

    public class Interactive
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public float score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class FinalScreenshot
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details9 details { get; set; }
    }

    public class Details9
    {
        public string data { get; set; }
        public string type { get; set; }
        public long timestamp { get; set; }
        public int timing { get; set; }
    }

    public class LargestContentfulPaintElement
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details10 details { get; set; }
    }

    public class Details10
    {
        public string type { get; set; }
        public Item4[] items { get; set; }
        public Heading2[] headings { get; set; }
    }

    public class Item4
    {
        public Node node { get; set; }
    }

    public class Node
    {
        public string path { get; set; }
        public string selector { get; set; }
        public Boundingrect boundingRect { get; set; }
        public string snippet { get; set; }
        public string lhId { get; set; }
        public string nodeLabel { get; set; }
        public string type { get; set; }
    }

    public class Boundingrect
    {
        public int height { get; set; }
        public int left { get; set; }
        public int right { get; set; }
        public int bottom { get; set; }
        public int top { get; set; }
        public int width { get; set; }
    }

    public class Heading2
    {
        public string key { get; set; }
        public string text { get; set; }
        public string itemType { get; set; }
    }

    public class ScriptTreemapData
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details11 details { get; set; }
    }

    public class Details11
    {
        public Node1[] nodes { get; set; }
        public string type { get; set; }
    }

    public class Node1
    {
        public string name { get; set; }
        public int resourceBytes { get; set; }
        public int unusedBytes { get; set; }
    }

    public class LayoutShiftElements
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details12 details { get; set; }
    }

    public class Details12
    {
        public object[] headings { get; set; }
        public object[] items { get; set; }
        public string type { get; set; }
    }

    public class UsesLongCacheTtl
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details13 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details13
    {
        public object[] items { get; set; }
        public object[] headings { get; set; }
        public string type { get; set; }
        public Summary1 summary { get; set; }
    }

    public class Summary1
    {
        public int wastedBytes { get; set; }
    }

    public class DomSize
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details14 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details14
    {
        public Heading3[] headings { get; set; }
        public string type { get; set; }
        public Item5[] items { get; set; }
    }

    public class Heading3
    {
        public string itemType { get; set; }
        public string key { get; set; }
        public string text { get; set; }
    }

    public class Item5
    {
        public int value { get; set; }
        public string statistic { get; set; }
        public Node2 node { get; set; }
    }

    public class Node2
    {
        public string selector { get; set; }
        public string lhId { get; set; }
        public Boundingrect1 boundingRect { get; set; }
        public string snippet { get; set; }
        public string type { get; set; }
        public string nodeLabel { get; set; }
        public string path { get; set; }
    }

    public class Boundingrect1
    {
        public int bottom { get; set; }
        public int right { get; set; }
        public int height { get; set; }
        public int left { get; set; }
        public int top { get; set; }
        public int width { get; set; }
    }

    public class UsesTextCompression
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details15 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details15
    {
        public object[] headings { get; set; }
        public int overallSavingsBytes { get; set; }
        public int overallSavingsMs { get; set; }
        public string type { get; set; }
        public object[] items { get; set; }
    }

    public class LongTasks
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details16 details { get; set; }
    }

    public class Details16
    {
        public Heading4[] headings { get; set; }
        public Item6[] items { get; set; }
        public string type { get; set; }
    }

    public class Heading4
    {
        public string text { get; set; }
        public string itemType { get; set; }
        public string key { get; set; }
        public int granularity { get; set; }
    }

    public class Item6
    {
        public int duration { get; set; }
        public int startTime { get; set; }
        public string url { get; set; }
    }

    public class MaxPotentialFid
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public float score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class UnsizedImages
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details17 details { get; set; }
    }

    public class Details17
    {
        public object[] headings { get; set; }
        public string type { get; set; }
        public object[] items { get; set; }
    }

    public class ResourceSummary
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details18 details { get; set; }
    }

    public class Details18
    {
        public string type { get; set; }
        public Heading5[] headings { get; set; }
        public Item7[] items { get; set; }
    }

    public class Heading5
    {
        public string itemType { get; set; }
        public string key { get; set; }
        public string text { get; set; }
    }

    public class Item7
    {
        public int transferSize { get; set; }
        public int requestCount { get; set; }
        public string resourceType { get; set; }
        public string label { get; set; }
    }

    public class FirstMeaningfulPaint
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public float numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class NonCompositedAnimations
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details19 details { get; set; }
    }

    public class Details19
    {
        public string type { get; set; }
        public object[] items { get; set; }
        public object[] headings { get; set; }
    }

    public class UsesOptimizedImages
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details20 details { get; set; }
        public object[] warnings { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details20
    {
        public object[] headings { get; set; }
        public object[] items { get; set; }
        public int overallSavingsMs { get; set; }
        public string type { get; set; }
        public int overallSavingsBytes { get; set; }
    }

    public class NetworkServerLatency
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details21 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details21
    {
        public string type { get; set; }
        public object[] headings { get; set; }
        public object[] items { get; set; }
    }

    public class UserTimings
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details22 details { get; set; }
    }

    public class Details22
    {
        public Heading6[] headings { get; set; }
        public Item8[] items { get; set; }
        public string type { get; set; }
    }

    public class Heading6
    {
        public string text { get; set; }
        public string itemType { get; set; }
        public string key { get; set; }
        public float granularity { get; set; }
    }

    public class Item8
    {
        public float startTime { get; set; }
        public string timingType { get; set; }
        public string name { get; set; }
        public float duration { get; set; }
    }

    public class LcpLazyLoaded
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details23 details { get; set; }
    }

    public class Details23
    {
        public string type { get; set; }
        public Heading7[] headings { get; set; }
        public Item9[] items { get; set; }
    }

    public class Heading7
    {
        public string key { get; set; }
        public string itemType { get; set; }
        public string text { get; set; }
    }

    public class Item9
    {
        public Node3 node { get; set; }
    }

    public class Node3
    {
        public string nodeLabel { get; set; }
        public Boundingrect2 boundingRect { get; set; }
        public string type { get; set; }
        public string path { get; set; }
        public string snippet { get; set; }
        public string selector { get; set; }
        public string lhId { get; set; }
    }

    public class Boundingrect2
    {
        public int bottom { get; set; }
        public int right { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int top { get; set; }
        public int left { get; set; }
    }

    public class UnusedCssRules
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details24 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details24
    {
        public object[] headings { get; set; }
        public object[] items { get; set; }
        public int overallSavingsBytes { get; set; }
        public int overallSavingsMs { get; set; }
        public string type { get; set; }
    }

    public class TotalBlockingTime
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public float score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Redirects
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details25 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details25
    {
        public Item10[] items { get; set; }
        public int overallSavingsMs { get; set; }
        public Heading8[] headings { get; set; }
        public string type { get; set; }
    }

    public class Item10
    {
        public int wastedMs { get; set; }
        public string url { get; set; }
    }

    public class Heading8
    {
        public string key { get; set; }
        public string label { get; set; }
        public string valueType { get; set; }
    }

    public class UsesResponsiveImages
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details26 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details26
    {
        public object[] items { get; set; }
        public int overallSavingsBytes { get; set; }
        public int overallSavingsMs { get; set; }
        public object[] headings { get; set; }
        public string type { get; set; }
    }

    public class FullPageScreenshot
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details27 details { get; set; }
    }

    public class Details27
    {
        public Nodes nodes { get; set; }
        public string type { get; set; }
        public Screenshot screenshot { get; set; }
    }

    public class Nodes
    {
        public _618BODY _618BODY { get; set; }
        public _617Rect _617rect { get; set; }
        public _615SCRIPT _615SCRIPT { get; set; }
        public _613SCRIPT _613SCRIPT { get; set; }
        public Page2DIV page2DIV { get; set; }
        public Page1DIV page1DIV { get; set; }
        public _61LINK _61LINK { get; set; }
        public _612SCRIPT _612SCRIPT { get; set; }
        public _65SCRIPT _65SCRIPT { get; set; }
        public _64META _64META { get; set; }
        public _616SCRIPT _616SCRIPT { get; set; }
        public _610SCRIPT _610SCRIPT { get; set; }
        public _67SCRIPT _67SCRIPT { get; set; }
        public _60LINK _60LINK { get; set; }
        public _68SCRIPT _68SCRIPT { get; set; }
        public _69SCRIPT _69SCRIPT { get; set; }
        public _66SCRIPT _66SCRIPT { get; set; }
        public _62META _62META { get; set; }
        public Page0IMG page0IMG { get; set; }
        public _614SCRIPT _614SCRIPT { get; set; }
        public _63META _63META { get; set; }
        public _611SCRIPT _611SCRIPT { get; set; }
    }

    public class _618BODY
    {
        public int width { get; set; }
        public int right { get; set; }
        public int height { get; set; }
        public int left { get; set; }
        public int top { get; set; }
        public int bottom { get; set; }
    }

    public class _617Rect
    {
        public int width { get; set; }
        public int right { get; set; }
        public int bottom { get; set; }
        public int top { get; set; }
        public int height { get; set; }
        public int left { get; set; }
    }

    public class _615SCRIPT
    {
        public int height { get; set; }
        public int right { get; set; }
        public int width { get; set; }
        public int bottom { get; set; }
        public int left { get; set; }
        public int top { get; set; }
    }

    public class _613SCRIPT
    {
        public int bottom { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int top { get; set; }
        public int left { get; set; }
        public int right { get; set; }
    }

    public class Page2DIV
    {
        public int left { get; set; }
        public int bottom { get; set; }
        public int width { get; set; }
        public int right { get; set; }
        public int height { get; set; }
        public int top { get; set; }
    }

    public class Page1DIV
    {
        public int height { get; set; }
        public int left { get; set; }
        public int right { get; set; }
        public int bottom { get; set; }
        public int width { get; set; }
        public int top { get; set; }
    }

    public class _61LINK
    {
        public int left { get; set; }
        public int top { get; set; }
        public int bottom { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int right { get; set; }
    }

    public class _612SCRIPT
    {
        public int top { get; set; }
        public int width { get; set; }
        public int bottom { get; set; }
        public int left { get; set; }
        public int height { get; set; }
        public int right { get; set; }
    }

    public class _65SCRIPT
    {
        public int bottom { get; set; }
        public int right { get; set; }
        public int height { get; set; }
        public int left { get; set; }
        public int width { get; set; }
        public int top { get; set; }
    }

    public class _64META
    {
        public int left { get; set; }
        public int width { get; set; }
        public int right { get; set; }
        public int top { get; set; }
        public int bottom { get; set; }
        public int height { get; set; }
    }

    public class _616SCRIPT
    {
        public int left { get; set; }
        public int width { get; set; }
        public int top { get; set; }
        public int height { get; set; }
        public int bottom { get; set; }
        public int right { get; set; }
    }

    public class _610SCRIPT
    {
        public int left { get; set; }
        public int right { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int bottom { get; set; }
        public int height { get; set; }
    }

    public class _67SCRIPT
    {
        public int height { get; set; }
        public int left { get; set; }
        public int bottom { get; set; }
        public int width { get; set; }
        public int right { get; set; }
        public int top { get; set; }
    }

    public class _60LINK
    {
        public int right { get; set; }
        public int left { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int top { get; set; }
        public int bottom { get; set; }
    }

    public class _68SCRIPT
    {
        public int top { get; set; }
        public int left { get; set; }
        public int height { get; set; }
        public int bottom { get; set; }
        public int width { get; set; }
        public int right { get; set; }
    }

    public class _69SCRIPT
    {
        public int height { get; set; }
        public int bottom { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int right { get; set; }
        public int left { get; set; }
    }

    public class _66SCRIPT
    {
        public int bottom { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int right { get; set; }
        public int left { get; set; }
        public int height { get; set; }
    }

    public class _62META
    {
        public int height { get; set; }
        public int top { get; set; }
        public int bottom { get; set; }
        public int width { get; set; }
        public int right { get; set; }
        public int left { get; set; }
    }

    public class Page0IMG
    {
        public int right { get; set; }
        public int height { get; set; }
        public int left { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int bottom { get; set; }
    }

    public class _614SCRIPT
    {
        public int left { get; set; }
        public int height { get; set; }
        public int bottom { get; set; }
        public int width { get; set; }
        public int top { get; set; }
        public int right { get; set; }
    }

    public class _63META
    {
        public int right { get; set; }
        public int height { get; set; }
        public int left { get; set; }
        public int bottom { get; set; }
        public int width { get; set; }
        public int top { get; set; }
    }

    public class _611SCRIPT
    {
        public int left { get; set; }
        public int bottom { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int right { get; set; }
        public int top { get; set; }
    }

    public class Screenshot
    {
        public int height { get; set; }
        public int width { get; set; }
        public string data { get; set; }
    }

    public class NetworkRequests
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details28 details { get; set; }
    }

    public class Details28
    {
        public Item11[] items { get; set; }
        public string type { get; set; }
        public Heading9[] headings { get; set; }
    }

    public class Item11
    {
        public bool finished { get; set; }
        public int transferSize { get; set; }
        public string protocol { get; set; }
        public string mimeType { get; set; }
        public float startTime { get; set; }
        public int resourceSize { get; set; }
        public float endTime { get; set; }
        public string url { get; set; }
        public int statusCode { get; set; }
        public string resourceType { get; set; }
    }

    public class Heading9
    {
        public string text { get; set; }
        public string key { get; set; }
        public string itemType { get; set; }
        public int granularity { get; set; }
        public string displayUnit { get; set; }
    }

    public class TotalByteWeight
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details29 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details29
    {
        public string type { get; set; }
        public Heading10[] headings { get; set; }
        public Item12[] items { get; set; }
    }

    public class Heading10
    {
        public string itemType { get; set; }
        public string text { get; set; }
        public string key { get; set; }
    }

    public class Item12
    {
        public int totalBytes { get; set; }
        public string url { get; set; }
    }

    public class FirstContentfulPaint
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public float numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class UnusedJavascript
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public float score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details30 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details30
    {
        public string type { get; set; }
        public int overallSavingsMs { get; set; }
        public Item13[] items { get; set; }
        public Heading11[] headings { get; set; }
        public int overallSavingsBytes { get; set; }
    }

    public class Item13
    {
        public float wastedPercent { get; set; }
        public int totalBytes { get; set; }
        public string url { get; set; }
        public int wastedBytes { get; set; }
    }

    public class Heading11
    {
        public string valueType { get; set; }
        public string label { get; set; }
        public Subitemsheading1 subItemsHeading { get; set; }
        public string key { get; set; }
    }

    public class Subitemsheading1
    {
        public string valueType { get; set; }
        public string key { get; set; }
    }

    public class FontDisplay
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details31 details { get; set; }
        public object[] warnings { get; set; }
    }

    public class Details31
    {
        public object[] headings { get; set; }
        public object[] items { get; set; }
        public string type { get; set; }
    }

    public class UnminifiedJavascript
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details32 details { get; set; }
        public object[] warnings { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details32
    {
        public object[] headings { get; set; }
        public int overallSavingsMs { get; set; }
        public int overallSavingsBytes { get; set; }
        public string type { get; set; }
        public object[] items { get; set; }
    }

    public class NoUnloadListeners
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
    }

    public class NetworkRtt
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details33 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details33
    {
        public string type { get; set; }
        public object[] items { get; set; }
        public object[] headings { get; set; }
    }

    public class LargestContentfulPaint
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public float score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class LegacyJavascript
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details34 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details34
    {
        public string type { get; set; }
        public Item14[] items { get; set; }
        public int overallSavingsBytes { get; set; }
        public int overallSavingsMs { get; set; }
        public Heading12[] headings { get; set; }
    }

    public class Item14
    {
        public string url { get; set; }
        public int wastedBytes { get; set; }
        public int totalBytes { get; set; }
        public Subitems1 subItems { get; set; }
    }

    public class Subitems1
    {
        public string type { get; set; }
        public Item15[] items { get; set; }
    }

    public class Item15
    {
        public Location location { get; set; }
        public string signal { get; set; }
    }

    public class Location
    {
        public string urlProvider { get; set; }
        public int column { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public int line { get; set; }
    }

    public class Heading12
    {
        public Subitemsheading2 subItemsHeading { get; set; }
        public string label { get; set; }
        public string valueType { get; set; }
        public string key { get; set; }
    }

    public class Subitemsheading2
    {
        public string key { get; set; }
        public string valueType { get; set; }
    }

    public class DuplicatedJavascript
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details35 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details35
    {
        public int overallSavingsBytes { get; set; }
        public object[] items { get; set; }
        public string type { get; set; }
        public int overallSavingsMs { get; set; }
        public object[] headings { get; set; }
    }

    public class Diagnostics
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details36 details { get; set; }
    }

    public class Details36
    {
        public string type { get; set; }
        public Item16[] items { get; set; }
    }

    public class Item16
    {
        public float rtt { get; set; }
        public int numTasksOver100ms { get; set; }
        public int totalByteWeight { get; set; }
        public object maxServerLatency { get; set; }
        public float maxRtt { get; set; }
        public int numFonts { get; set; }
        public int numTasksOver10ms { get; set; }
        public int mainDocumentTransferSize { get; set; }
        public int numScripts { get; set; }
        public int numTasksOver25ms { get; set; }
        public float totalTaskTime { get; set; }
        public int numStylesheets { get; set; }
        public int numTasksOver500ms { get; set; }
        public float throughput { get; set; }
        public int numRequests { get; set; }
        public int numTasksOver50ms { get; set; }
        public int numTasks { get; set; }
    }

    public class TimingBudget
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
    }

    public class MainThreadTasks
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details37 details { get; set; }
    }

    public class Details37
    {
        public Item17[] items { get; set; }
        public string type { get; set; }
        public Heading13[] headings { get; set; }
    }

    public class Item17
    {
        public float startTime { get; set; }
        public float duration { get; set; }
    }

    public class Heading13
    {
        public string text { get; set; }
        public string itemType { get; set; }
        public string key { get; set; }
        public int granularity { get; set; }
    }

    public class ScreenshotThumbnails
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details38 details { get; set; }
    }

    public class Details38
    {
        public Item18[] items { get; set; }
        public string type { get; set; }
        public int scale { get; set; }
    }

    public class Item18
    {
        public int timing { get; set; }
        public string data { get; set; }
        public long timestamp { get; set; }
    }

    public class PerformanceBudget
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
    }

    public class NoDocumentWrite
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details39 details { get; set; }
    }

    public class Details39
    {
        public object[] items { get; set; }
        public string type { get; set; }
        public object[] headings { get; set; }
    }

    public class EfficientAnimatedContent
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details40 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details40
    {
        public object[] items { get; set; }
        public int overallSavingsMs { get; set; }
        public string type { get; set; }
        public int overallSavingsBytes { get; set; }
        public object[] headings { get; set; }
    }

    public class UsesPassiveEventListeners
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details41 details { get; set; }
    }

    public class Details41
    {
        public object[] items { get; set; }
        public string type { get; set; }
        public object[] headings { get; set; }
    }

    public class MainthreadWorkBreakdown
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details42 details { get; set; }
        public float numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details42
    {
        public Heading14[] headings { get; set; }
        public Item19[] items { get; set; }
        public string type { get; set; }
    }

    public class Heading14
    {
        public string text { get; set; }
        public string itemType { get; set; }
        public string key { get; set; }
        public int granularity { get; set; }
    }

    public class Item19
    {
        public string group { get; set; }
        public float duration { get; set; }
        public string groupLabel { get; set; }
    }

    public class CumulativeLayoutShift
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details43 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details43
    {
        public string type { get; set; }
        public Item20[] items { get; set; }
    }

    public class Item20
    {
        public int cumulativeLayoutShiftMainFrame { get; set; }
        public int totalCumulativeLayoutShift { get; set; }
    }

    public class Viewport
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string explanation { get; set; }
    }

    public class BootupTime
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details44 details { get; set; }
        public float numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details44
    {
        public Heading15[] headings { get; set; }
        public Summary2 summary { get; set; }
        public string type { get; set; }
        public Item21[] items { get; set; }
    }

    public class Summary2
    {
        public float wastedMs { get; set; }
    }

    public class Heading15
    {
        public string text { get; set; }
        public string itemType { get; set; }
        public string key { get; set; }
        public int granularity { get; set; }
    }

    public class Item21
    {
        public float scripting { get; set; }
        public float scriptParseCompile { get; set; }
        public float total { get; set; }
        public string url { get; set; }
    }

    public class CriticalRequestChains
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public Details45 details { get; set; }
    }

    public class Details45
    {
        public string type { get; set; }
        public Chains chains { get; set; }
        public Longestchain longestChain { get; set; }
    }

    public class Chains
    {
        public _3ED0AF5724F690749B5FC69EEC10EA5E _3ED0AF5724F690749B5FC69EEC10EA5E { get; set; }
    }

    public class _3ED0AF5724F690749B5FC69EEC10EA5E
    {
        public Children children { get; set; }
        public Request2 request { get; set; }
    }

    public class Children
    {
        public _3ED0AF5724F690749B5FC69EEC10EA5ERedirect _3ED0AF5724F690749B5FC69EEC10EA5Eredirect { get; set; }
    }

    public class _3ED0AF5724F690749B5FC69EEC10EA5ERedirect
    {
        public Request request { get; set; }
        public Children1 children { get; set; }
    }

    public class Request
    {
        public int transferSize { get; set; }
        public float endTime { get; set; }
        public float startTime { get; set; }
        public float responseReceivedTime { get; set; }
        public string url { get; set; }
    }

    public class Children1
    {
        public _439 _439 { get; set; }
    }

    public class _439
    {
        public Request1 request { get; set; }
    }

    public class Request1
    {
        public float responseReceivedTime { get; set; }
        public string url { get; set; }
        public float endTime { get; set; }
        public int transferSize { get; set; }
        public float startTime { get; set; }
    }

    public class Request2
    {
        public string url { get; set; }
        public int transferSize { get; set; }
        public float responseReceivedTime { get; set; }
        public float endTime { get; set; }
        public float startTime { get; set; }
    }

    public class Longestchain
    {
        public float duration { get; set; }
        public int transferSize { get; set; }
        public int length { get; set; }
    }

    public class PreloadLcpImage
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int score { get; set; }
        public string scoreDisplayMode { get; set; }
        public Details46 details { get; set; }
        public int numericValue { get; set; }
        public string numericUnit { get; set; }
    }

    public class Details46
    {
        public Item22[] items { get; set; }
        public int overallSavingsMs { get; set; }
        public string type { get; set; }
        public Heading16[] headings { get; set; }
    }

    public class Item22
    {
        public string url { get; set; }
        public int wastedMs { get; set; }
        public Node4 node { get; set; }
    }

    public class Node4
    {
        public Boundingrect3 boundingRect { get; set; }
        public string path { get; set; }
        public string selector { get; set; }
        public string snippet { get; set; }
        public string lhId { get; set; }
        public string nodeLabel { get; set; }
        public string type { get; set; }
    }

    public class Boundingrect3
    {
        public int top { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int bottom { get; set; }
        public int right { get; set; }
        public int left { get; set; }
    }

    public class Heading16
    {
        public string valueType { get; set; }
        public string key { get; set; }
        public string label { get; set; }
    }

    public class ThirdPartyFacades
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public object score { get; set; }
        public string scoreDisplayMode { get; set; }
    }

    public class Categories
    {
        public Performance performance { get; set; }
    }

    public class Performance
    {
        public string id { get; set; }
        public string title { get; set; }
        public float score { get; set; }
        public Auditref[] auditRefs { get; set; }
    }

    public class Auditref
    {
        public string id { get; set; }
        public int weight { get; set; }
        public string group { get; set; }
        public string acronym { get; set; }
        public string[] relevantAudits { get; set; }
    }

    public class Categorygroups
    {
        public PwaInstallable pwainstallable { get; set; }
        public BestPracticesBrowserCompat bestpracticesbrowsercompat { get; set; }
        public SeoMobile seomobile { get; set; }
        public BestPracticesUx bestpracticesux { get; set; }
        public PwaOptimized pwaoptimized { get; set; }
        public A11yAudioVideo a11yaudiovideo { get; set; }
        public BestPracticesGeneral bestpracticesgeneral { get; set; }
        public Budgets budgets { get; set; }
        public SeoContent seocontent { get; set; }
        public A11yNavigation a11ynavigation { get; set; }
        public A11yAria a11yaria { get; set; }
        public Diagnostics1 diagnostics { get; set; }
        public A11yNamesLabels a11ynameslabels { get; set; }
        public A11yLanguage a11ylanguage { get; set; }
        public BestPracticesTrustSafety bestpracticestrustsafety { get; set; }
        public Metrics3 metrics { get; set; }
        public SeoCrawl seocrawl { get; set; }
        public A11yBestPractices a11ybestpractices { get; set; }
        public LoadOpportunities loadopportunities { get; set; }
        public A11yColorContrast a11ycolorcontrast { get; set; }
        public A11yTablesLists a11ytableslists { get; set; }
    }

    public class PwaInstallable
    {
        public string title { get; set; }
    }

    public class BestPracticesBrowserCompat
    {
        public string title { get; set; }
    }

    public class SeoMobile
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class BestPracticesUx
    {
        public string title { get; set; }
    }

    public class PwaOptimized
    {
        public string title { get; set; }
    }

    public class A11yAudioVideo
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class BestPracticesGeneral
    {
        public string title { get; set; }
    }

    public class Budgets
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class SeoContent
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class A11yNavigation
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class A11yAria
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class Diagnostics1
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class A11yNamesLabels
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class A11yLanguage
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class BestPracticesTrustSafety
    {
        public string title { get; set; }
    }

    public class Metrics3
    {
        public string title { get; set; }
    }

    public class SeoCrawl
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class A11yBestPractices
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class LoadOpportunities
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class A11yColorContrast
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class A11yTablesLists
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class Timing
    {
        public float total { get; set; }
    }

    public class I18n
    {
        public Rendererformattedstrings rendererFormattedStrings { get; set; }
    }

    public class Rendererformattedstrings
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

}

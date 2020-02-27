namespace SFB
{
    public static class SFBFactory
    {
        public static IStandaloneFileBrowser Create()
        {
#if UNITY_STANDALONE_OSX
            return new StandaloneFileBrowserMac();
#elif UNITY_STANDALONE_WIN
            return new StandaloneFileBrowserWindows();
#elif UNITY_STANDALONE_LINUX
            return new StandaloneFileBrowserLinux();
#elif UNITY_EDITOR
            return new StandaloneFileBrowserEditor();
#endif
        }
    }
}
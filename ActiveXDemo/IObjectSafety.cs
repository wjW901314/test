using System.Runtime.InteropServices;

namespace ActiveXDemo
{
    [ComImport]
    [Guid("3CB4DA58-9364-465A-BDB3-81CE2D49E7DB")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IObjectSafety
    {
        [PreserveSig]
        void GetInterfaceSafetyOptions(int riid, [MarshalAs(UnmanagedType.U4)] out int pdwSupportedOptions, [MarshalAs(UnmanagedType.U4)] out int pdwEnabledOptions);

        [PreserveSig]
        void SetInterfaceSafetyOptions(int riid, [MarshalAs(UnmanagedType.U4)] int dwOptionSetMask, [MarshalAs(UnmanagedType.U4)] int dwEnabledOptions);
    }
}
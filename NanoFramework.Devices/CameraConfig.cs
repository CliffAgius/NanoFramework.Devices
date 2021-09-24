
namespace NanoFramework.Devices
{
    /// <summary>
    /// Used to set the configuration of the Camera Module default values used are for the AI Thinker Modeule of the ESP32-Cam.
    /// </summary>
    class CameraConfig
    {
        /// <summary>
        /// GPIO pin for camera power down line (If not needed set to -1)
        /// Default = 32
        /// </summary>
        public int CAM_PIN_PWDN { get; set; } = 32;
        /// <summary>
        /// GPIO pin for camera reset line (If not needed set to -1)
        /// Default = -1
        /// </summary>
        public int CAM_PIN_RESET { get; set; } = -1;
        /// <summary>
        /// GPIO pin for camera XCLK line
        /// Default = 0
        /// </summary>
        public int CAM_PIN_XCLK { get; set; } = 0;
        /// <summary>
        /// GPIO pin for camera SDA line
        /// Default = 26
        /// </summary>
        public int CAM_PIN_SIOD { get; set; } = 26;
        /// <summary>
        /// GPIO pin for camera SCL line
        /// Default = 27
        /// </summary>
        public int CAM_PIN_SIOC { get; set; } = 27;
        /// <summary>
        /// GPIO pin for camera D7 line
        /// Default = 35
        /// </summary>
        public int CAM_PIN_D7 { get; set; } = 35;
        /// <summary>
        /// GPIO pin for camera D6 line
        /// Default = 34
        /// </summary>
        public int CAM_PIN_D6 { get; set; } = 34;
        /// <summary>
        /// GPIO pin for camera D5 line
        /// Default = 39
        /// </summary>
        public int CAM_PIN_D5 { get; set; } = 39;
        /// <summary>
        /// GPIO pin for camera D4 line
        /// Default = 36
        /// </summary>
        public int CAM_PIN_D4 { get; set; } = 36;
        /// <summary>
        /// GPIO pin for camera D3 line
        /// Default = 21
        /// </summary>
        public int CAM_PIN_D3 { get; set; } = 21;
        /// <summary>
        /// GPIO pin for camera D2 line
        /// Default = 19
        /// </summary>
        public int CAM_PIN_D2 { get; set; } = 19;
        /// <summary>
        /// GPIO pin for camera D1 line
        /// Default = 18
        /// </summary>
        public int CAM_PIN_D1 { get; set; } = 18;
        /// <summary>
        /// GPIO pin for camera D0 line
        /// Default = 5
        /// </summary>
        public int CAM_PIN_D0 { get; set; } = 5;
        /// <summary>
        /// GPIO pin for camera VSYNC line
        /// Default = 25
        /// </summary>
        public int CAM_PIN_VSYNC { get; set; } = 25;
        /// <summary>
        /// GPIO pin for camera HREF line
        /// Default = 23
        /// </summary>
        public int CAM_PIN_HREF { get; set; } = 23;
        /// <summary>
        /// GPIO pin for camera PCLK line
        /// Default = 22
        /// </summary>
        public int CAM_PIN_PCLK { get; set; } = 22;
        /// <summary>
        /// Clock frequency 20MHz or 10MHz for OV2640 double FPS (Experimental)
        /// Default - 20Mhz
        /// </summary>
        public int CAM_XCLK_FREQ_HZ { get; set; } = 20000000;
        /// <summary>
        /// Format of the pixel data: PIXFORMAT_ + YUV422|GRAYSCALE|RGB565|JPEG
        /// Enum Default = PIXFORMAT_JPEG
        /// </summary>
        public PixelFormat CAM_PIXEL_FORMAT { get; set; } = PixelFormat.PIXFORMAT_JPEG;
        /// <summary>
        /// The image size taken by the Camera: FrameSize.FRAMESIZE_ + QQVGA|UXGA|SVGA Do not use sizes above QVGA when CAM_PIXEL_FORMAT is not JPEG
        /// Enum Default = FrameSize.FRAMESIZE_SVGA (800x600)
        /// </summary>
        public FrameSize CAM_FRAME_SIZE { get; set; } = FrameSize.FRAMESIZE_SVGA;
        /// <summary>
        /// Quaility of the JPEG Image - 0-63 lower number means higher quality
        /// Default - 12
        /// </summary>
        public int CAM_JPEG_QUALITY { get; set; } = 12;

    }
}


enum PixelFormat
{
    PIXFORMAT_RGB565,    // 2BPP/RGB565
    PIXFORMAT_YUV422,    // 2BPP/YUV422
    PIXFORMAT_GRAYSCALE, // 1BPP/GRAYSCALE
    PIXFORMAT_JPEG,      // JPEG/COMPRESSED
    PIXFORMAT_RGB888,    // 3BPP/RGB888
    PIXFORMAT_RAW,       // RAW
    PIXFORMAT_RGB444,    // 3BP2P/RGB444
    PIXFORMAT_RGB555,    // 3BP2P/RGB555
}

enum FrameSize
{
    FRAMESIZE_96X96,    // 96x96
    FRAMESIZE_QQVGA,    // 160x120
    FRAMESIZE_QCIF,     // 176x144
    FRAMESIZE_HQVGA,    // 240x176
    FRAMESIZE_240X240,  // 240x240
    FRAMESIZE_QVGA,     // 320x240
    FRAMESIZE_CIF,      // 400x296
    FRAMESIZE_HVGA,     // 480x320
    FRAMESIZE_VGA,      // 640x480
    FRAMESIZE_SVGA,     // 800x600
    FRAMESIZE_XGA,      // 1024x768
    FRAMESIZE_HD,       // 1280x720
    FRAMESIZE_SXGA,     // 1280x1024
    FRAMESIZE_UXGA,     // 1600x1200
    // 3MP Sensors
    FRAMESIZE_FHD,      // 1920x1080
    FRAMESIZE_P_HD,     //  720x1280
    FRAMESIZE_P_3MP,    //  864x1536
    FRAMESIZE_QXGA,     // 2048x1536
    // 5MP Sensors
    FRAMESIZE_QHD,      // 2560x1440
    FRAMESIZE_WQXGA,    // 2560x1600
    FRAMESIZE_P_FHD,    // 1080x1920
    FRAMESIZE_QSXGA,    // 2560x1920
    FRAMESIZE_INVALID
}
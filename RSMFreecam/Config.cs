using System.Collections.Generic;

namespace RSMFreecam
{
    public class Config
    {
        public static float DefaultSpeed = 5.0f;
        public static float ShiftSpeed = 20.0f;
        public static float Precision = 1.0f;
        public static float FilterIntensity = 1.0f;


        // This list isn't actually used but I'm keeping it just in case it's needed in the likely scenario that disabling ALL controls causes issues
        public static List<int> DisabledControls = new List<int>()
        {
            30,     // A and D (Character Movement)
            31,     // W and S (Character Movement)
            21,     // LEFT SHIFT
            36,     // LEFT CTRL
            22,     // SPACE
            44,     // Q
            38,     // E
            71,     // W (Vehicle Movement)
            72,     // S (Vehicle Movement)
            59,     // A and D (Vehicle Movement)
            60,     // LEFT SHIFT and LEFT CTRL (Vehicle Movement)
            85,     // Q (Radio Wheel)
            86,     // E (Vehicle Horn)
            15,     // Mouse wheel up
            14,     // Mouse wheel down
            37,     // Controller R1 (PS) / RT (XBOX)
            80,     // Controller O (PS) / B (XBOX)
            228,    
            229,    
            172,    
            173,    
            37,     
            44,     
            178,    
            244,   
        };

        public static List<string> Filters = new List<string>()
        {
            "None",
    "CAMERA_BW",
    "CAMERA_secuirity",
    "CAMERA_secuirity_FUZZ",
    "NG_filmic01",
    "NG_filmic02",
    "NG_filmic03",
    "NG_filmic04",
    "NG_filmic05",
    "NG_filmic06",
    "NG_filmic07",
    "NG_filmic08",
    "NG_filmic09",
    "NG_filmic10",
    "NG_filmic11",
    "NG_filmic12",
    "NG_filmic13",
    "NG_filmic14",
    "NG_filmic15",
    "NG_filmic16",
    "NG_filmic17",
    "NG_filmic18",
    "NG_filmic19",
    "NG_filmic20",
    "NG_filmic21",
    "NG_filmic22",
    "NG_filmic23",
    "NG_filmic24",
    "NG_filmic25",
    "NG_filmnoir_BW01",
    "NG_filmnoir_BW02",
    "phone_cam",
    "phone_cam1",
    "phone_cam2",
    "phone_cam3",
    "phone_cam4",
    "phone_cam5",
    "phone_cam6",
    "phone_cam7",
    "phone_cam8",
    "phone_cam9",
    "phone_cam10",
    "phone_cam11",
    "phone_cam12",
        };
    }
}

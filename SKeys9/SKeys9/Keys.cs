using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SKeys9 {
	public static class Keys {
		public static Dictionary<int, string> KeyNames = new Dictionary<int, string> {
			//0
			{ 0x1, "" },
			{ 0x2, "" }, 
			//3
			{ 0x4, "" },
			{ 0x5, "" }, 
			{ 0x6, "" },
			//7
			{ 0x8, "" }, 
			{ 0x9, "" },
			//A
			//B
			{ 0xC, "" },
			{ 0xD, "" },
			//E
			//F

			{ 0x10, "" },
			{ 0x11, "" },
			{ 0x12, "" }, 
			{ 0x13, "" }, 
			{ 0x14, "" },
			{ 0x15, "" },
			//16
			{ 0x17, "" },
			{ 0x18, "" },
			{ 0x19, "" },
			//1A
			{ 0x1B, "" },
			{ 0x1C, "" },
			{ 0x1D, "" },
			{ 0x1E, "" },
			{ 0x1F, "" }, 
			
			{ 0x20, "Space" }, 
			{ 0x21, "" }, 
			{ 0x22, "" }, 
			{ 0x23, "" }, 
			{ 0x24, "" },
			{ 0x25, "" },
			{ 0x26, "" }, 
			{ 0x27, "" },
			{ 0x28, "" },
			{ 0x29, "" },
			{ 0x2A, "" },
			{ 0x2B, "" },
			{ 0x2C, "" }, 
			{ 0x2D, "" }, 
			{ 0x2E, "" },
			{ 0x2F, "" },

			{ 0x30, "" },
			{ 0x31, "" }, 
			{ 0x32, "" }, 
			{ 0x33, "" },
			{ 0x34, "" },
			{ 0x35, "" }, 
			{ 0x36, "" }, 
			{ 0x37, "" },
			{ 0x38, "" }, 
			{ 0x39, "" }, 
			//3A
			//3B
			//3C
			//3D
			//3E
			//3F

			//40
			{ 0x41, "" },
			{ 0x42, "" }, 
			{ 0x43, "" }, 
			{ 0x44, "" }, 
			{ 0x45, "" }, 
			{ 0x46, "" },
			{ 0x47, "" }, 
			{ 0x48, "" }, 
			{ 0x49, "" }, 
			{ 0x4A, "" }, 
			{ 0x4B, "" }, 
			{ 0x4C, "" }, 
			{ 0x4D, "" }, 
			{ 0x4E, "" },
			{ 0x4F, "" }, 

			{ 0x50, "" },
			{ 0x51, "" }, 
			{ 0x52, "" }, 
			{ 0x53, "" }, 
			{ 0x54, "" }, 
			{ 0x55, "" }, 
			{ 0x56, "" },
			{ 0x57, "" },
			{ 0x58, "" },
			{ 0x59, "" }, 
			{ 0x5A, "" }, 
			{ 0x5B, "" }, 
			{ 0x5C, "" },
			{ 0x5D, "" },
			//5E
			{ 0x5F, "" },

			{ 0x60, "" }, 
			{ 0x61, "" }, 
			{ 0x62, "" }, 
			{ 0x63, "" }, 
			{ 0x64, "" }, 
			{ 0x65, "" }, 
			{ 0x66, "" }, 
			{ 0x67, "" }, 
			{ 0x68, "" }, 
			{ 0x69, "" },
			{ 0x6A, "" }, 
			{ 0x6B, "" },
			{ 0x6C, "" },
			{ 0x6D, "" }, 
			{ 0x6E, "" },
			{ 0x6F, "" }, 

			{ 0X70, "" }, 
			{ 0X71, "" }, 
			{ 0X72, "" }, 
			{ 0X73, "" }, 
			{ 0X74, "" }, 
			{ 0X75, "" }, 
			{ 0X76, "" }, 
			{ 0X77, "" }, 
			{ 0X78, "" }, 
			{ 0X79, "" },
			{ 0X7A, "" },
			{ 0X7B, "" },
			{ 0X7C, "" },
			{ 0X7D, "" },
			{ 0X7E, "" },
			{ 0X7F, "" },

			{ 0X80, "" },
			{ 0X81, "" },
			{ 0X82, "" },
			{ 0X83, "" },
			{ 0X84, "" }, 
			{ 0X85, "" }, 
			{ 0X86, "" }, 
			{ 0X87, "" }, 
			//88
			//89
			//8A
			//8B
			//8C
			//8D
			//8E
			//8F

			{ 0x90, "" },
			{ 0x91, "" },
			//92
			//93
			//94
			//95
			//96
			{ 0x97, "ScrUp" }, // Hijacked
			{ 0x98, "ScrDn" }, // Hijacked
			{ 0x99, "ScrLeft" }, // Hijacked
			{ 0x9A, "ScrRight" }, // Hijacked
			
			{ 0x9B, "" }, // Hijacked
			{ 0x9C, "" }, // Hijacked
			{ 0x9D, "" }, // Hijacked
			//9E
			//9F

			{ 0xA0, "" },
			{ 0xA1, "" },
			{ 0xA2, "" }, 
			{ 0xA3, "" }, 
			{ 0xA4, "" }, 
			{ 0xA5, "" }, 
			{ 0xA6, "" }, 
			{ 0xA7, "" }, 
			{ 0xA8, "" }, 
			{ 0xA9, "" }, 
			{ 0xAA, "" }, 
			{ 0xAB, "" }, 
			{ 0xAC, "" }, 
			{ 0xAD, "" }, 
			{ 0xAE, "" }, 
			{ 0xAF, "" },

			{ 0xB0, "" },
			{ 0xB1, "" },
			{ 0xB2, "" },
			{ 0xB3, "" },
			{ 0xB4, "" },
			{ 0xB5, "" },
			{ 0xB6, "" },
			{ 0xB7, "" },
			//B8
			//B9
			{ 0xBA, "" },
			{ 0xBB, "" },
			{ 0xBC, "" },
			{ 0xBD, "" },
			{ 0xBE, "" },
			{ 0xBF, "" },

			{ 0xC0, "" },
			//C1
			//C2
			//C3
			//C4
			//C5
			//C6
			//C7
			//C8
			//C9
			//CA
			//CB
			//CC
			//CD
			//CE
			//CF

			//D0
			//D1
			//D2
			//D3
			//D4
			//D5
			//D6
			//D7
			//D8
			//D9
			//DA
			{ 0xDB, "" },
			{ 0xDC, "" },
			{ 0xDD, "" },
			{ 0xDE, "" },
			//DF

			//E0
			//E1
			{ 0xE2, "" },
			//E3
			//E4
			{ 0xE5, "" },
			//E6
			{ 0xE7, "" },
			//E8
			//E9
			//EA
			//EB
			//EC
			//ED
			//EE
			//EF

			//F0
			//F1
			//F2
			//F3
			//F4
			//F5
			{ 0xF6, "" },
			{ 0xF7, "" },
			{ 0xF8, "" },
			{ 0xF9, "" },
			{ 0xFA, "" },
			{ 0xFB, "" },
			//FC
			{ 0xFD, "" },
			{ 0xFE, "" },
			//FF
		};
	
		public static void ReadJson() {
			string filePath = Path.Combine(Environment.CurrentDirectory, "keyNames.json");
			if (!File.Exists(filePath)) {
				string json = JsonConvert.SerializeObject(KeyNames, Formatting.Indented);
				File.WriteAllText(filePath, json);
			}
			string file = File.ReadAllText(filePath);
			KeyNames = JsonConvert.DeserializeObject<Dictionary<int, string>>(file);
			//Process.Start(dir);
		}
	}

}

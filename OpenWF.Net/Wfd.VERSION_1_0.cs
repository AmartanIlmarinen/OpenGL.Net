
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenWF
{
	public partial class Wfd
	{
		public const int OPENWFD_VERSION_1_0 = (1);

		public const int NONE = (0);

		public const int INVALID_PORT_ID = (0);

		public const int INVALID_PIPELINE_ID = (0);

		public const int INVALID_PIPELINE_LAYER = (0);

		public const int DEFAULT_DEVICE_ID = (0);

		public const int MAX_INT = 16777216;

		public const int MAX_FLOAT = 16777216;

		public const int INVALID_HANDLE = 0;

		public const int VENDOR = 0x7500;

		public const int RENDERER = 0x7501;

		public const int VERSION = 0x7502;

		public const int EXTENSIONS = 0x7503;

		public const int STRING_ID_FORCE_32BIT = 0x7FFFFFFF;

		public const int ERROR_NONE = 0;

		public const int ERROR_OUT_OF_MEMORY = 0x7510;

		public const int ERROR_ILLEGAL_ARGUMENT = 0x7511;

		public const int ERROR_NOT_SUPPORTED = 0x7512;

		public const int ERROR_BAD_ATTRIBUTE = 0x7513;

		public const int ERROR_IN_USE = 0x7514;

		public const int ERROR_BUSY = 0x7515;

		public const int ERROR_BAD_DEVICE = 0x7516;

		public const int ERROR_BAD_HANDLE = 0x7517;

		public const int ERROR_INCONSISTENCY = 0x7518;

		public const int ERROR_FORCE_32BIT = 0x7FFFFFFF;

		public const int DEVICE_FILTER_PORT_ID = 0x7530;

		public const int DEVICE_FILTER_FORCE_32BIT = 0x7FFFFFFF;

		public const int COMMIT_ENTIRE_DEVICE = 0x7550;

		public const int COMMIT_ENTIRE_PORT = 0x7551;

		public const int COMMIT_PIPELINE = 0x7552;

		public const int COMMIT_FORCE_32BIT = 0x7FFFFFFF;

		public const int DEVICE_ID = 0x7560;

		public const int DEVICE_ATTRIB_FORCE_32BIT = 0x7FFFFFFF;

		public const int EVENT_INVALID = 0x7580;

		public const int EVENT_NONE = 0x7581;

		public const int EVENT_DESTROYED = 0x7582;

		public const int EVENT_PORT_ATTACH_DETACH = 0x7583;

		public const int EVENT_PORT_PROTECTION_FAILURE = 0x7584;

		public const int EVENT_PIPELINE_BIND_SOURCE_COMPLETE = 0x7585;

		public const int EVENT_PIPELINE_BIND_MASK_COMPLETE = 0x7586;

		public const int EVENT_FORCE_32BIT = 0x7FFFFFFF;

		public const int EVENT_PIPELINE_BIND_QUEUE_SIZE = 0x75C0;

		public const int EVENT_TYPE = 0x75C1;

		public const int EVENT_PORT_ATTACH_PORT_ID = 0x75C2;

		public const int EVENT_PORT_ATTACH_STATE = 0x75C3;

		public const int EVENT_PORT_PROTECTION_PORT_ID = 0x75C4;

		public const int EVENT_PIPELINE_BIND_PIPELINE_ID = 0x75C5;

		public const int EVENT_PIPELINE_BIND_SOURCE = 0x75C6;

		public const int EVENT_PIPELINE_BIND_MASK = 0x75C7;

		public const int EVENT_PIPELINE_BIND_QUEUE_OVERFLOW = 0x75C8;

		public const int EVENT_ATTRIB_FORCE_32BIT = 0x7FFFFFFF;

		public const int PORT_MODE_WIDTH = 0x7600;

		public const int PORT_MODE_HEIGHT = 0x7601;

		public const int PORT_MODE_REFRESH_RATE = 0x7602;

		public const int PORT_MODE_FLIP_MIRROR_SUPPORT = 0x7603;

		public const int PORT_MODE_ROTATION_SUPPORT = 0x7604;

		public const int PORT_MODE_INTERLACED = 0x7605;

		public const int PORT_MODE_ATTRIB_FORCE_32BIT = 0x7FFFFFFF;

		public const int PORT_ID = 0x7620;

		public const int PORT_TYPE = 0x7621;

		public const int PORT_DETACHABLE = 0x7622;

		public const int PORT_ATTACHED = 0x7623;

		public const int PORT_NATIVE_RESOLUTION = 0x7624;

		public const int PORT_PHYSICAL_SIZE = 0x7625;

		public const int PORT_FILL_PORT_AREA = 0x7626;

		public const int PORT_BACKGROUND_COLOR = 0x7627;

		public const int PORT_FLIP = 0x7628;

		public const int PORT_MIRROR = 0x7629;

		public const int PORT_ROTATION = 0x762A;

		public const int PORT_POWER_MODE = 0x762B;

		public const int PORT_GAMMA_RANGE = 0x762C;

		public const int PORT_GAMMA = 0x762D;

		public const int PORT_PARTIAL_REFRESH_SUPPORT = 0x762E;

		public const int PORT_PARTIAL_REFRESH_MAXIMUM = 0x762F;

		public const int PORT_PARTIAL_REFRESH_ENABLE = 0x7630;

		public const int PORT_PARTIAL_REFRESH_RECTANGLE = 0x7631;

		public const int PORT_PIPELINE_ID_COUNT = 0x7632;

		public const int PORT_BINDABLE_PIPELINE_IDS = 0x7633;

		public const int PORT_PROTECTION_ENABLE = 0x7634;

		public const int PORT_ATTRIB_FORCE_32BIT = 0x7FFFFFFF;

		public const int PORT_TYPE_INTERNAL = 0x7660;

		public const int PORT_TYPE_COMPOSITE = 0x7661;

		public const int PORT_TYPE_SVIDEO = 0x7662;

		public const int PORT_TYPE_COMPONENT_YPbPr = 0x7663;

		public const int PORT_TYPE_COMPONENT_RGB = 0x7664;

		public const int PORT_TYPE_COMPONENT_RGBHV = 0x7665;

		public const int PORT_TYPE_DVI = 0x7666;

		public const int PORT_TYPE_HDMI = 0x7667;

		public const int PORT_TYPE_DISPLAYPORT = 0x7668;

		public const int PORT_TYPE_OTHER = 0x7669;

		public const int PORT_TYPE_FORCE_32BIT = 0x7FFFFFFF;

		public const int POWER_MODE_OFF = 0x7680;

		public const int POWER_MODE_SUSPEND = 0x7681;

		public const int POWER_MODE_LIMITED_USE = 0x7682;

		public const int POWER_MODE_ON = 0x7683;

		public const int POWER_MODE_FORCE_32BIT = 0x7FFFFFFF;

		public const int PARTIAL_REFRESH_NONE = 0x7690;

		public const int PARTIAL_REFRESH_VERTICAL = 0x7691;

		public const int PARTIAL_REFRESH_HORIZONTAL = 0x7692;

		public const int PARTIAL_REFRESH_BOTH = 0x7693;

		public const int PARTIAL_REFRESH_FORCE_32BIT = 0x7FFFFFFF;

		public const int DISPLAY_DATA_FORMAT_NONE = 0x76A0;

		public const int DISPLAY_DATA_FORMAT_EDID_V1 = 0x76A1;

		public const int DISPLAY_DATA_FORMAT_EDID_V2 = 0x76A2;

		public const int DISPLAY_DATA_FORMAT_DISPLAYID = 0x76A3;

		public const int DISPLAY_DATA_FORMAT_FORCE_32BIT = 0x7FFFFFFF;

		public const int ROTATION_SUPPORT_NONE = 0x76D0;

		public const int ROTATION_SUPPORT_LIMITED = 0x76D1;

		public const int ROTATION_SUPPORT_FORMAT_FORCE_32BIT = 0x7FFFFFFF;

		public const int PIPELINE_ID = 0x7720;

		public const int PIPELINE_PORTID = 0x7721;

		public const int PIPELINE_LAYER = 0x7722;

		public const int PIPELINE_SHAREABLE = 0x7723;

		public const int PIPELINE_DIRECT_REFRESH = 0x7724;

		public const int PIPELINE_MAX_SOURCE_SIZE = 0x7725;

		public const int PIPELINE_SOURCE_RECTANGLE = 0x7726;

		public const int PIPELINE_FLIP = 0x7727;

		public const int PIPELINE_MIRROR = 0x7728;

		public const int PIPELINE_ROTATION_SUPPORT = 0x7729;

		public const int PIPELINE_ROTATION = 0x772A;

		public const int PIPELINE_SCALE_RANGE = 0x772B;

		public const int PIPELINE_SCALE_FILTER = 0x772C;

		public const int PIPELINE_DESTINATION_RECTANGLE = 0x772D;

		public const int PIPELINE_TRANSPARENCY_ENABLE = 0x772E;

		public const int PIPELINE_GLOBAL_ALPHA = 0x772F;

		public const int PIPELINE_ATTRIB_FORCE_32BIT = 0x7FFFFFFF;

		public const int SCALE_FILTER_NONE = 0x7760;

		public const int SCALE_FILTER_FASTER = 0x7761;

		public const int SCALE_FILTER_BETTER = 0x7762;

		public const int SCALE_FILTER_FORCE_32BIT = 0x7FFFFFFF;

		public const int TRANSPARENCY_NONE = 0;

		public const int TRANSPARENCY_SOURCE_COLOR = (1 << 0);

		public const int TRANSPARENCY_GLOBAL_ALPHA = (1 << 1);

		public const int TRANSPARENCY_SOURCE_ALPHA = (1 << 2);

		public const int TRANSPARENCY_MASK = (1 << 3);

		public const int TRANSPARENCY_FORCE_32BIT = 0x7FFFFFFF;

		public const int TSC_FORMAT_UINT8_RGB_8_8_8_LINEAR = 0x7790;

		public const int TSC_FORMAT_UINT8_RGB_5_6_5_LINEAR = 0x7791;

		public const int TSC_FORMAT_FORCE_32BIT = 0x7FFFFFFF;

		public const int TRANSITION_INVALID = 0x77E0;

		public const int TRANSITION_IMMEDIATE = 0x77E1;

		public const int TRANSITION_AT_VSYNC = 0x77E2;

		public const int TRANSITION_FORCE_32BIT = 0x7FFFFFFF;

		public static int GetStrings(UInt32 device, WFDStringID name, [Out] IntPtr[] strings, int stringsCount)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_strings = strings)
				{
					Debug.Assert(Delegates.pwfdGetStrings != null, "pwfdGetStrings not implemented");
					retValue = Delegates.pwfdGetStrings(device, name, p_strings, stringsCount);
					LogCommand("wfdGetStrings", retValue, device, name, strings, stringsCount					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static bool IsExtensionSupported(UInt32 device, [Out] char[] @string)
		{
			bool retValue;

			unsafe {
				fixed (char* p_string = @string)
				{
					Debug.Assert(Delegates.pwfdIsExtensionSupported != null, "pwfdIsExtensionSupported not implemented");
					retValue = Delegates.pwfdIsExtensionSupported(device, p_string);
					LogCommand("wfdIsExtensionSupported", retValue, device, @string					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static WFDErrorCode GetError(UInt32 device)
		{
			WFDErrorCode retValue;

			Debug.Assert(Delegates.pwfdGetError != null, "pwfdGetError not implemented");
			retValue = Delegates.pwfdGetError(device);
			LogCommand("wfdGetError", retValue, device			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static int EnumerateDevices(int[] deviceIds, int deviceIdsCount, int[] filterList)
		{
			int retValue;

			unsafe {
				fixed (int* p_deviceIds = deviceIds)
				fixed (int* p_filterList = filterList)
				{
					Debug.Assert(Delegates.pwfdEnumerateDevices != null, "pwfdEnumerateDevices not implemented");
					retValue = Delegates.pwfdEnumerateDevices(p_deviceIds, deviceIdsCount, p_filterList);
					LogCommand("wfdEnumerateDevices", retValue, deviceIds, deviceIdsCount, filterList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static UInt32 CreateDevice(int deviceId, int[] attribList)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwfdCreateDevice != null, "pwfdCreateDevice not implemented");
					retValue = Delegates.pwfdCreateDevice(deviceId, p_attribList);
					LogCommand("wfdCreateDevice", retValue, deviceId, attribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static WFDErrorCode DestroyDevice(UInt32 device)
		{
			WFDErrorCode retValue;

			Debug.Assert(Delegates.pwfdDestroyDevice != null, "pwfdDestroyDevice not implemented");
			retValue = Delegates.pwfdDestroyDevice(device);
			LogCommand("wfdDestroyDevice", retValue, device			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void DeviceCommit(UInt32 device, WFDCommitType type, UInt32 handle)
		{
			Debug.Assert(Delegates.pwfdDeviceCommit != null, "pwfdDeviceCommit not implemented");
			Delegates.pwfdDeviceCommit(device, type, handle);
			LogCommand("wfdDeviceCommit", null, device, type, handle			);
			DebugCheckErrors(null);
		}

		public static int GetDeviceAttrib(UInt32 device, WFDDeviceAttrib attrib)
		{
			int retValue;

			Debug.Assert(Delegates.pwfdGetDeviceAttribi != null, "pwfdGetDeviceAttribi not implemented");
			retValue = Delegates.pwfdGetDeviceAttribi(device, attrib);
			LogCommand("wfdGetDeviceAttribi", retValue, device, attrib			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void SetDeviceAttrib(UInt32 device, WFDDeviceAttrib attrib, int value)
		{
			Debug.Assert(Delegates.pwfdSetDeviceAttribi != null, "pwfdSetDeviceAttribi not implemented");
			Delegates.pwfdSetDeviceAttribi(device, attrib, value);
			LogCommand("wfdSetDeviceAttribi", null, device, attrib, value			);
			DebugCheckErrors(null);
		}

		public static UInt32 CreateEvent(UInt32 device, int[] attribList)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwfdCreateEvent != null, "pwfdCreateEvent not implemented");
					retValue = Delegates.pwfdCreateEvent(device, p_attribList);
					LogCommand("wfdCreateEvent", retValue, device, attribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void DestroyEvent(UInt32 device, UInt32 @event)
		{
			Debug.Assert(Delegates.pwfdDestroyEvent != null, "pwfdDestroyEvent not implemented");
			Delegates.pwfdDestroyEvent(device, @event);
			LogCommand("wfdDestroyEvent", null, device, @event			);
			DebugCheckErrors(null);
		}

		public static int GetEventAttrib(UInt32 device, UInt32 @event, WFDEventAttrib attrib)
		{
			int retValue;

			Debug.Assert(Delegates.pwfdGetEventAttribi != null, "pwfdGetEventAttribi not implemented");
			retValue = Delegates.pwfdGetEventAttribi(device, @event, attrib);
			LogCommand("wfdGetEventAttribi", retValue, device, @event, attrib			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void DeviceEventAsync(UInt32 device, UInt32 @event, IntPtr display, IntPtr sync)
		{
			Debug.Assert(Delegates.pwfdDeviceEventAsync != null, "pwfdDeviceEventAsync not implemented");
			Delegates.pwfdDeviceEventAsync(device, @event, display, sync);
			LogCommand("wfdDeviceEventAsync", null, device, @event, display, sync			);
			DebugCheckErrors(null);
		}

		public static WFDEventType DeviceEventWait(UInt32 device, UInt32 @event, ulong timeout)
		{
			WFDEventType retValue;

			Debug.Assert(Delegates.pwfdDeviceEventWait != null, "pwfdDeviceEventWait not implemented");
			retValue = Delegates.pwfdDeviceEventWait(device, @event, timeout);
			LogCommand("wfdDeviceEventWait", retValue, device, @event, timeout			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void DeviceEventFilter(UInt32 device, UInt32 @event, WFDEventType[] filter)
		{
			unsafe {
				fixed (WFDEventType* p_filter = filter)
				{
					Debug.Assert(Delegates.pwfdDeviceEventFilter != null, "pwfdDeviceEventFilter not implemented");
					Delegates.pwfdDeviceEventFilter(device, @event, p_filter);
					LogCommand("wfdDeviceEventFilter", null, device, @event, filter					);
				}
			}
			DebugCheckErrors(null);
		}

		public static int EnumeratePorts(UInt32 device, int[] portIds, int portIdsCount, int[] filterList)
		{
			int retValue;

			unsafe {
				fixed (int* p_portIds = portIds)
				fixed (int* p_filterList = filterList)
				{
					Debug.Assert(Delegates.pwfdEnumeratePorts != null, "pwfdEnumeratePorts not implemented");
					retValue = Delegates.pwfdEnumeratePorts(device, p_portIds, portIdsCount, p_filterList);
					LogCommand("wfdEnumeratePorts", retValue, device, portIds, portIdsCount, filterList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static UInt32 CreatePort(UInt32 device, int portId, int[] attribList)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwfdCreatePort != null, "pwfdCreatePort not implemented");
					retValue = Delegates.pwfdCreatePort(device, portId, p_attribList);
					LogCommand("wfdCreatePort", retValue, device, portId, attribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void DestroyPort(UInt32 device, UInt32 port)
		{
			Debug.Assert(Delegates.pwfdDestroyPort != null, "pwfdDestroyPort not implemented");
			Delegates.pwfdDestroyPort(device, port);
			LogCommand("wfdDestroyPort", null, device, port			);
			DebugCheckErrors(null);
		}

		public static int GetPortModes(UInt32 device, UInt32 port, [Out] UInt32[] modes, int modesCount)
		{
			int retValue;

			unsafe {
				fixed (UInt32* p_modes = modes)
				{
					Debug.Assert(Delegates.pwfdGetPortModes != null, "pwfdGetPortModes not implemented");
					retValue = Delegates.pwfdGetPortModes(device, port, p_modes, modesCount);
					LogCommand("wfdGetPortModes", retValue, device, port, modes, modesCount					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static int GetPortModeAttrib(UInt32 device, UInt32 port, UInt32 mode, WFDPortModeAttrib attrib)
		{
			int retValue;

			Debug.Assert(Delegates.pwfdGetPortModeAttribi != null, "pwfdGetPortModeAttribi not implemented");
			retValue = Delegates.pwfdGetPortModeAttribi(device, port, mode, attrib);
			LogCommand("wfdGetPortModeAttribi", retValue, device, port, mode, attrib			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static float GetPortModeAttrib(UInt32 device, UInt32 port, UInt32 mode, WFDPortModeAttrib attrib)
		{
			float retValue;

			Debug.Assert(Delegates.pwfdGetPortModeAttribf != null, "pwfdGetPortModeAttribf not implemented");
			retValue = Delegates.pwfdGetPortModeAttribf(device, port, mode, attrib);
			LogCommand("wfdGetPortModeAttribf", retValue, device, port, mode, attrib			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void SetPortMode(UInt32 device, UInt32 port, UInt32 mode)
		{
			Debug.Assert(Delegates.pwfdSetPortMode != null, "pwfdSetPortMode not implemented");
			Delegates.pwfdSetPortMode(device, port, mode);
			LogCommand("wfdSetPortMode", null, device, port, mode			);
			DebugCheckErrors(null);
		}

		public static UInt32 GetCurrentPortMode(UInt32 device, UInt32 port)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pwfdGetCurrentPortMode != null, "pwfdGetCurrentPortMode not implemented");
			retValue = Delegates.pwfdGetCurrentPortMode(device, port);
			LogCommand("wfdGetCurrentPortMode", retValue, device, port			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static int GetPortAttrib(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib)
		{
			int retValue;

			Debug.Assert(Delegates.pwfdGetPortAttribi != null, "pwfdGetPortAttribi not implemented");
			retValue = Delegates.pwfdGetPortAttribi(device, port, attrib);
			LogCommand("wfdGetPortAttribi", retValue, device, port, attrib			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static float GetPortAttrib(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib)
		{
			float retValue;

			Debug.Assert(Delegates.pwfdGetPortAttribf != null, "pwfdGetPortAttribf not implemented");
			retValue = Delegates.pwfdGetPortAttribf(device, port, attrib);
			LogCommand("wfdGetPortAttribf", retValue, device, port, attrib			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void GetPortAttrib(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, int count, [Out] int[] value)
		{
			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.pwfdGetPortAttribiv != null, "pwfdGetPortAttribiv not implemented");
					Delegates.pwfdGetPortAttribiv(device, port, attrib, count, p_value);
					LogCommand("wfdGetPortAttribiv", null, device, port, attrib, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		public static void GetPortAttrib(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, int count, [Out] float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pwfdGetPortAttribfv != null, "pwfdGetPortAttribfv not implemented");
					Delegates.pwfdGetPortAttribfv(device, port, attrib, count, p_value);
					LogCommand("wfdGetPortAttribfv", null, device, port, attrib, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		public static void SetPortAttrib(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, int value)
		{
			Debug.Assert(Delegates.pwfdSetPortAttribi != null, "pwfdSetPortAttribi not implemented");
			Delegates.pwfdSetPortAttribi(device, port, attrib, value);
			LogCommand("wfdSetPortAttribi", null, device, port, attrib, value			);
			DebugCheckErrors(null);
		}

		public static void SetPortAttrib(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, float value)
		{
			Debug.Assert(Delegates.pwfdSetPortAttribf != null, "pwfdSetPortAttribf not implemented");
			Delegates.pwfdSetPortAttribf(device, port, attrib, value);
			LogCommand("wfdSetPortAttribf", null, device, port, attrib, value			);
			DebugCheckErrors(null);
		}

		public static void SetPortAttrib(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, int count, int[] value)
		{
			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.pwfdSetPortAttribiv != null, "pwfdSetPortAttribiv not implemented");
					Delegates.pwfdSetPortAttribiv(device, port, attrib, count, p_value);
					LogCommand("wfdSetPortAttribiv", null, device, port, attrib, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		public static void SetPortAttrib(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, int count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pwfdSetPortAttribfv != null, "pwfdSetPortAttribfv not implemented");
					Delegates.pwfdSetPortAttribfv(device, port, attrib, count, p_value);
					LogCommand("wfdSetPortAttribfv", null, device, port, attrib, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		public static void BindPipelineToPort(UInt32 device, UInt32 port, UInt32 pipeline)
		{
			Debug.Assert(Delegates.pwfdBindPipelineToPort != null, "pwfdBindPipelineToPort not implemented");
			Delegates.pwfdBindPipelineToPort(device, port, pipeline);
			LogCommand("wfdBindPipelineToPort", null, device, port, pipeline			);
			DebugCheckErrors(null);
		}

		public static int GetDisplayDataFormat(UInt32 device, UInt32 port, [Out] WFDDisplayDataFormat[] format, int formatCount)
		{
			int retValue;

			unsafe {
				fixed (WFDDisplayDataFormat* p_format = format)
				{
					Debug.Assert(Delegates.pwfdGetDisplayDataFormats != null, "pwfdGetDisplayDataFormats not implemented");
					retValue = Delegates.pwfdGetDisplayDataFormats(device, port, p_format, formatCount);
					LogCommand("wfdGetDisplayDataFormats", retValue, device, port, format, formatCount					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static int GetDisplayData(UInt32 device, UInt32 port, WFDDisplayDataFormat format, [Out] byte[] data, int dataCount)
		{
			int retValue;

			unsafe {
				fixed (byte* p_data = data)
				{
					Debug.Assert(Delegates.pwfdGetDisplayData != null, "pwfdGetDisplayData not implemented");
					retValue = Delegates.pwfdGetDisplayData(device, port, format, p_data, dataCount);
					LogCommand("wfdGetDisplayData", retValue, device, port, format, data, dataCount					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static int EnumeratePipelines(UInt32 device, int[] pipelineIds, int pipelineIdsCount, int[] filterList)
		{
			int retValue;

			unsafe {
				fixed (int* p_pipelineIds = pipelineIds)
				fixed (int* p_filterList = filterList)
				{
					Debug.Assert(Delegates.pwfdEnumeratePipelines != null, "pwfdEnumeratePipelines not implemented");
					retValue = Delegates.pwfdEnumeratePipelines(device, p_pipelineIds, pipelineIdsCount, p_filterList);
					LogCommand("wfdEnumeratePipelines", retValue, device, pipelineIds, pipelineIdsCount, filterList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static UInt32 CreatePipeline(UInt32 device, int pipelineId, int[] attribList)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwfdCreatePipeline != null, "pwfdCreatePipeline not implemented");
					retValue = Delegates.pwfdCreatePipeline(device, pipelineId, p_attribList);
					LogCommand("wfdCreatePipeline", retValue, device, pipelineId, attribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void DestroyPipeline(UInt32 device, UInt32 pipeline)
		{
			Debug.Assert(Delegates.pwfdDestroyPipeline != null, "pwfdDestroyPipeline not implemented");
			Delegates.pwfdDestroyPipeline(device, pipeline);
			LogCommand("wfdDestroyPipeline", null, device, pipeline			);
			DebugCheckErrors(null);
		}

		public static UInt32 CreateSourceFromImage(UInt32 device, UInt32 pipeline, IntPtr image, int[] attribList)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwfdCreateSourceFromImage != null, "pwfdCreateSourceFromImage not implemented");
					retValue = Delegates.pwfdCreateSourceFromImage(device, pipeline, image, p_attribList);
					LogCommand("wfdCreateSourceFromImage", retValue, device, pipeline, image, attribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static UInt32 CreateSourceFromStream(UInt32 device, UInt32 pipeline, UInt32 stream, int[] attribList)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwfdCreateSourceFromStream != null, "pwfdCreateSourceFromStream not implemented");
					retValue = Delegates.pwfdCreateSourceFromStream(device, pipeline, stream, p_attribList);
					LogCommand("wfdCreateSourceFromStream", retValue, device, pipeline, stream, attribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void DestroySource(UInt32 device, UInt32 source)
		{
			Debug.Assert(Delegates.pwfdDestroySource != null, "pwfdDestroySource not implemented");
			Delegates.pwfdDestroySource(device, source);
			LogCommand("wfdDestroySource", null, device, source			);
			DebugCheckErrors(null);
		}

		public static UInt32 CreateMaskFromImage(UInt32 device, UInt32 pipeline, IntPtr image, int[] attribList)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwfdCreateMaskFromImage != null, "pwfdCreateMaskFromImage not implemented");
					retValue = Delegates.pwfdCreateMaskFromImage(device, pipeline, image, p_attribList);
					LogCommand("wfdCreateMaskFromImage", retValue, device, pipeline, image, attribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static UInt32 CreateMaskFromStream(UInt32 device, UInt32 pipeline, UInt32 stream, int[] attribList)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwfdCreateMaskFromStream != null, "pwfdCreateMaskFromStream not implemented");
					retValue = Delegates.pwfdCreateMaskFromStream(device, pipeline, stream, p_attribList);
					LogCommand("wfdCreateMaskFromStream", retValue, device, pipeline, stream, attribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void DestroyMask(UInt32 device, UInt32 mask)
		{
			Debug.Assert(Delegates.pwfdDestroyMask != null, "pwfdDestroyMask not implemented");
			Delegates.pwfdDestroyMask(device, mask);
			LogCommand("wfdDestroyMask", null, device, mask			);
			DebugCheckErrors(null);
		}

		public static void BindSourceToPipeline(UInt32 device, UInt32 pipeline, UInt32 source, WFDTransition transition, WFDRect[] region)
		{
			unsafe {
				fixed (WFDRect* p_region = region)
				{
					Debug.Assert(Delegates.pwfdBindSourceToPipeline != null, "pwfdBindSourceToPipeline not implemented");
					Delegates.pwfdBindSourceToPipeline(device, pipeline, source, transition, p_region);
					LogCommand("wfdBindSourceToPipeline", null, device, pipeline, source, transition, region					);
				}
			}
			DebugCheckErrors(null);
		}

		public static void BindMaskToPipeline(UInt32 device, UInt32 pipeline, UInt32 mask, WFDTransition transition)
		{
			Debug.Assert(Delegates.pwfdBindMaskToPipeline != null, "pwfdBindMaskToPipeline not implemented");
			Delegates.pwfdBindMaskToPipeline(device, pipeline, mask, transition);
			LogCommand("wfdBindMaskToPipeline", null, device, pipeline, mask, transition			);
			DebugCheckErrors(null);
		}

		public static int GetPipelineAttrib(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib)
		{
			int retValue;

			Debug.Assert(Delegates.pwfdGetPipelineAttribi != null, "pwfdGetPipelineAttribi not implemented");
			retValue = Delegates.pwfdGetPipelineAttribi(device, pipeline, attrib);
			LogCommand("wfdGetPipelineAttribi", retValue, device, pipeline, attrib			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static float GetPipelineAttrib(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib)
		{
			float retValue;

			Debug.Assert(Delegates.pwfdGetPipelineAttribf != null, "pwfdGetPipelineAttribf not implemented");
			retValue = Delegates.pwfdGetPipelineAttribf(device, pipeline, attrib);
			LogCommand("wfdGetPipelineAttribf", retValue, device, pipeline, attrib			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void GetPipelineAttrib(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, int count, [Out] int[] value)
		{
			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.pwfdGetPipelineAttribiv != null, "pwfdGetPipelineAttribiv not implemented");
					Delegates.pwfdGetPipelineAttribiv(device, pipeline, attrib, count, p_value);
					LogCommand("wfdGetPipelineAttribiv", null, device, pipeline, attrib, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		public static void GetPipelineAttrib(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, int count, [Out] float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pwfdGetPipelineAttribfv != null, "pwfdGetPipelineAttribfv not implemented");
					Delegates.pwfdGetPipelineAttribfv(device, pipeline, attrib, count, p_value);
					LogCommand("wfdGetPipelineAttribfv", null, device, pipeline, attrib, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		public static void SetPipelineAttrib(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, int value)
		{
			Debug.Assert(Delegates.pwfdSetPipelineAttribi != null, "pwfdSetPipelineAttribi not implemented");
			Delegates.pwfdSetPipelineAttribi(device, pipeline, attrib, value);
			LogCommand("wfdSetPipelineAttribi", null, device, pipeline, attrib, value			);
			DebugCheckErrors(null);
		}

		public static void SetPipelineAttrib(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, float value)
		{
			Debug.Assert(Delegates.pwfdSetPipelineAttribf != null, "pwfdSetPipelineAttribf not implemented");
			Delegates.pwfdSetPipelineAttribf(device, pipeline, attrib, value);
			LogCommand("wfdSetPipelineAttribf", null, device, pipeline, attrib, value			);
			DebugCheckErrors(null);
		}

		public static void SetPipelineAttrib(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, int count, int[] value)
		{
			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.pwfdSetPipelineAttribiv != null, "pwfdSetPipelineAttribiv not implemented");
					Delegates.pwfdSetPipelineAttribiv(device, pipeline, attrib, count, p_value);
					LogCommand("wfdSetPipelineAttribiv", null, device, pipeline, attrib, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		public static void SetPipelineAttrib(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, int count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pwfdSetPipelineAttribfv != null, "pwfdSetPipelineAttribfv not implemented");
					Delegates.pwfdSetPipelineAttribfv(device, pipeline, attrib, count, p_value);
					LogCommand("wfdSetPipelineAttribfv", null, device, pipeline, attrib, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		public static int GetPipelineTransparency(UInt32 device, UInt32 pipeline, [Out] UInt32[] trans, int transCount)
		{
			int retValue;

			unsafe {
				fixed (UInt32* p_trans = trans)
				{
					Debug.Assert(Delegates.pwfdGetPipelineTransparency != null, "pwfdGetPipelineTransparency not implemented");
					retValue = Delegates.pwfdGetPipelineTransparency(device, pipeline, p_trans, transCount);
					LogCommand("wfdGetPipelineTransparency", retValue, device, pipeline, trans, transCount					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void SetPipelineTSColor(UInt32 device, UInt32 pipeline, WFDTSColorFormat colorFormat, int count, IntPtr color)
		{
			unsafe {
				{
					Debug.Assert(Delegates.pwfdSetPipelineTSColor != null, "pwfdSetPipelineTSColor not implemented");
					Delegates.pwfdSetPipelineTSColor(device, pipeline, colorFormat, count, color.ToPointer());
					LogCommand("wfdSetPipelineTSColor", null, device, pipeline, colorFormat, count, color					);
				}
			}
			DebugCheckErrors(null);
		}

		public static int GetPipelineLayerOrder(UInt32 device, UInt32 port, UInt32 pipeline)
		{
			int retValue;

			Debug.Assert(Delegates.pwfdGetPipelineLayerOrder != null, "pwfdGetPipelineLayerOrder not implemented");
			retValue = Delegates.pwfdGetPipelineLayerOrder(device, port, pipeline);
			LogCommand("wfdGetPipelineLayerOrder", retValue, device, port, pipeline			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetStrings", ExactSpelling = true)]
			internal extern static unsafe int wfdGetStrings(UInt32 device, WFDStringID name, IntPtr* strings, int stringsCount);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdIsExtensionSupported", ExactSpelling = true)]
			internal extern static unsafe bool wfdIsExtensionSupported(UInt32 device, char* @string);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetError", ExactSpelling = true)]
			internal extern static WFDErrorCode wfdGetError(UInt32 device);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdEnumerateDevices", ExactSpelling = true)]
			internal extern static unsafe int wfdEnumerateDevices(int* deviceIds, int deviceIdsCount, int* filterList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdCreateDevice", ExactSpelling = true)]
			internal extern static unsafe UInt32 wfdCreateDevice(int deviceId, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdDestroyDevice", ExactSpelling = true)]
			internal extern static WFDErrorCode wfdDestroyDevice(UInt32 device);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdDeviceCommit", ExactSpelling = true)]
			internal extern static void wfdDeviceCommit(UInt32 device, WFDCommitType type, UInt32 handle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetDeviceAttribi", ExactSpelling = true)]
			internal extern static int wfdGetDeviceAttribi(UInt32 device, WFDDeviceAttrib attrib);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdSetDeviceAttribi", ExactSpelling = true)]
			internal extern static void wfdSetDeviceAttribi(UInt32 device, WFDDeviceAttrib attrib, int value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdCreateEvent", ExactSpelling = true)]
			internal extern static unsafe UInt32 wfdCreateEvent(UInt32 device, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdDestroyEvent", ExactSpelling = true)]
			internal extern static void wfdDestroyEvent(UInt32 device, UInt32 @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetEventAttribi", ExactSpelling = true)]
			internal extern static int wfdGetEventAttribi(UInt32 device, UInt32 @event, WFDEventAttrib attrib);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdDeviceEventAsync", ExactSpelling = true)]
			internal extern static unsafe void wfdDeviceEventAsync(UInt32 device, UInt32 @event, IntPtr display, IntPtr sync);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdDeviceEventWait", ExactSpelling = true)]
			internal extern static WFDEventType wfdDeviceEventWait(UInt32 device, UInt32 @event, ulong timeout);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdDeviceEventFilter", ExactSpelling = true)]
			internal extern static unsafe void wfdDeviceEventFilter(UInt32 device, UInt32 @event, WFDEventType* filter);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdEnumeratePorts", ExactSpelling = true)]
			internal extern static unsafe int wfdEnumeratePorts(UInt32 device, int* portIds, int portIdsCount, int* filterList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdCreatePort", ExactSpelling = true)]
			internal extern static unsafe UInt32 wfdCreatePort(UInt32 device, int portId, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdDestroyPort", ExactSpelling = true)]
			internal extern static void wfdDestroyPort(UInt32 device, UInt32 port);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetPortModes", ExactSpelling = true)]
			internal extern static unsafe int wfdGetPortModes(UInt32 device, UInt32 port, UInt32* modes, int modesCount);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetPortModeAttribi", ExactSpelling = true)]
			internal extern static int wfdGetPortModeAttribi(UInt32 device, UInt32 port, UInt32 mode, WFDPortModeAttrib attrib);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetPortModeAttribf", ExactSpelling = true)]
			internal extern static float wfdGetPortModeAttribf(UInt32 device, UInt32 port, UInt32 mode, WFDPortModeAttrib attrib);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdSetPortMode", ExactSpelling = true)]
			internal extern static void wfdSetPortMode(UInt32 device, UInt32 port, UInt32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetCurrentPortMode", ExactSpelling = true)]
			internal extern static UInt32 wfdGetCurrentPortMode(UInt32 device, UInt32 port);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetPortAttribi", ExactSpelling = true)]
			internal extern static int wfdGetPortAttribi(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetPortAttribf", ExactSpelling = true)]
			internal extern static float wfdGetPortAttribf(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetPortAttribiv", ExactSpelling = true)]
			internal extern static unsafe void wfdGetPortAttribiv(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, int count, int* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetPortAttribfv", ExactSpelling = true)]
			internal extern static unsafe void wfdGetPortAttribfv(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, int count, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdSetPortAttribi", ExactSpelling = true)]
			internal extern static void wfdSetPortAttribi(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, int value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdSetPortAttribf", ExactSpelling = true)]
			internal extern static void wfdSetPortAttribf(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, float value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdSetPortAttribiv", ExactSpelling = true)]
			internal extern static unsafe void wfdSetPortAttribiv(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, int count, int* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdSetPortAttribfv", ExactSpelling = true)]
			internal extern static unsafe void wfdSetPortAttribfv(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, int count, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdBindPipelineToPort", ExactSpelling = true)]
			internal extern static void wfdBindPipelineToPort(UInt32 device, UInt32 port, UInt32 pipeline);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetDisplayDataFormats", ExactSpelling = true)]
			internal extern static unsafe int wfdGetDisplayDataFormats(UInt32 device, UInt32 port, WFDDisplayDataFormat* format, int formatCount);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetDisplayData", ExactSpelling = true)]
			internal extern static unsafe int wfdGetDisplayData(UInt32 device, UInt32 port, WFDDisplayDataFormat format, byte* data, int dataCount);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdEnumeratePipelines", ExactSpelling = true)]
			internal extern static unsafe int wfdEnumeratePipelines(UInt32 device, int* pipelineIds, int pipelineIdsCount, int* filterList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdCreatePipeline", ExactSpelling = true)]
			internal extern static unsafe UInt32 wfdCreatePipeline(UInt32 device, int pipelineId, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdDestroyPipeline", ExactSpelling = true)]
			internal extern static void wfdDestroyPipeline(UInt32 device, UInt32 pipeline);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdCreateSourceFromImage", ExactSpelling = true)]
			internal extern static unsafe UInt32 wfdCreateSourceFromImage(UInt32 device, UInt32 pipeline, IntPtr image, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdCreateSourceFromStream", ExactSpelling = true)]
			internal extern static unsafe UInt32 wfdCreateSourceFromStream(UInt32 device, UInt32 pipeline, UInt32 stream, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdDestroySource", ExactSpelling = true)]
			internal extern static void wfdDestroySource(UInt32 device, UInt32 source);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdCreateMaskFromImage", ExactSpelling = true)]
			internal extern static unsafe UInt32 wfdCreateMaskFromImage(UInt32 device, UInt32 pipeline, IntPtr image, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdCreateMaskFromStream", ExactSpelling = true)]
			internal extern static unsafe UInt32 wfdCreateMaskFromStream(UInt32 device, UInt32 pipeline, UInt32 stream, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdDestroyMask", ExactSpelling = true)]
			internal extern static void wfdDestroyMask(UInt32 device, UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdBindSourceToPipeline", ExactSpelling = true)]
			internal extern static unsafe void wfdBindSourceToPipeline(UInt32 device, UInt32 pipeline, UInt32 source, WFDTransition transition, WFDRect* region);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdBindMaskToPipeline", ExactSpelling = true)]
			internal extern static void wfdBindMaskToPipeline(UInt32 device, UInt32 pipeline, UInt32 mask, WFDTransition transition);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetPipelineAttribi", ExactSpelling = true)]
			internal extern static int wfdGetPipelineAttribi(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetPipelineAttribf", ExactSpelling = true)]
			internal extern static float wfdGetPipelineAttribf(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetPipelineAttribiv", ExactSpelling = true)]
			internal extern static unsafe void wfdGetPipelineAttribiv(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, int count, int* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetPipelineAttribfv", ExactSpelling = true)]
			internal extern static unsafe void wfdGetPipelineAttribfv(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, int count, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdSetPipelineAttribi", ExactSpelling = true)]
			internal extern static void wfdSetPipelineAttribi(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, int value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdSetPipelineAttribf", ExactSpelling = true)]
			internal extern static void wfdSetPipelineAttribf(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, float value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdSetPipelineAttribiv", ExactSpelling = true)]
			internal extern static unsafe void wfdSetPipelineAttribiv(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, int count, int* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdSetPipelineAttribfv", ExactSpelling = true)]
			internal extern static unsafe void wfdSetPipelineAttribfv(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, int count, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetPipelineTransparency", ExactSpelling = true)]
			internal extern static unsafe int wfdGetPipelineTransparency(UInt32 device, UInt32 pipeline, UInt32* trans, int transCount);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdSetPipelineTSColor", ExactSpelling = true)]
			internal extern static unsafe void wfdSetPipelineTSColor(UInt32 device, UInt32 pipeline, WFDTSColorFormat colorFormat, int count, void* color);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfdGetPipelineLayerOrder", ExactSpelling = true)]
			internal extern static int wfdGetPipelineLayerOrder(UInt32 device, UInt32 port, UInt32 pipeline);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wfdGetStrings(UInt32 device, WFDStringID name, IntPtr* strings, int stringsCount);

			internal static wfdGetStrings pwfdGetStrings;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wfdIsExtensionSupported(UInt32 device, char* @string);

			internal static wfdIsExtensionSupported pwfdIsExtensionSupported;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate WFDErrorCode wfdGetError(UInt32 device);

			internal static wfdGetError pwfdGetError;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wfdEnumerateDevices(int* deviceIds, int deviceIdsCount, int* filterList);

			internal static wfdEnumerateDevices pwfdEnumerateDevices;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wfdCreateDevice(int deviceId, int* attribList);

			internal static wfdCreateDevice pwfdCreateDevice;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate WFDErrorCode wfdDestroyDevice(UInt32 device);

			internal static wfdDestroyDevice pwfdDestroyDevice;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfdDeviceCommit(UInt32 device, WFDCommitType type, UInt32 handle);

			internal static wfdDeviceCommit pwfdDeviceCommit;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int wfdGetDeviceAttribi(UInt32 device, WFDDeviceAttrib attrib);

			internal static wfdGetDeviceAttribi pwfdGetDeviceAttribi;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfdSetDeviceAttribi(UInt32 device, WFDDeviceAttrib attrib, int value);

			internal static wfdSetDeviceAttribi pwfdSetDeviceAttribi;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wfdCreateEvent(UInt32 device, int* attribList);

			internal static wfdCreateEvent pwfdCreateEvent;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfdDestroyEvent(UInt32 device, UInt32 @event);

			internal static wfdDestroyEvent pwfdDestroyEvent;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int wfdGetEventAttribi(UInt32 device, UInt32 @event, WFDEventAttrib attrib);

			internal static wfdGetEventAttribi pwfdGetEventAttribi;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfdDeviceEventAsync(UInt32 device, UInt32 @event, IntPtr display, IntPtr sync);

			internal static wfdDeviceEventAsync pwfdDeviceEventAsync;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate WFDEventType wfdDeviceEventWait(UInt32 device, UInt32 @event, ulong timeout);

			internal static wfdDeviceEventWait pwfdDeviceEventWait;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfdDeviceEventFilter(UInt32 device, UInt32 @event, WFDEventType* filter);

			internal static wfdDeviceEventFilter pwfdDeviceEventFilter;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wfdEnumeratePorts(UInt32 device, int* portIds, int portIdsCount, int* filterList);

			internal static wfdEnumeratePorts pwfdEnumeratePorts;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wfdCreatePort(UInt32 device, int portId, int* attribList);

			internal static wfdCreatePort pwfdCreatePort;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfdDestroyPort(UInt32 device, UInt32 port);

			internal static wfdDestroyPort pwfdDestroyPort;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wfdGetPortModes(UInt32 device, UInt32 port, UInt32* modes, int modesCount);

			internal static wfdGetPortModes pwfdGetPortModes;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int wfdGetPortModeAttribi(UInt32 device, UInt32 port, UInt32 mode, WFDPortModeAttrib attrib);

			internal static wfdGetPortModeAttribi pwfdGetPortModeAttribi;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate float wfdGetPortModeAttribf(UInt32 device, UInt32 port, UInt32 mode, WFDPortModeAttrib attrib);

			internal static wfdGetPortModeAttribf pwfdGetPortModeAttribf;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfdSetPortMode(UInt32 device, UInt32 port, UInt32 mode);

			internal static wfdSetPortMode pwfdSetPortMode;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 wfdGetCurrentPortMode(UInt32 device, UInt32 port);

			internal static wfdGetCurrentPortMode pwfdGetCurrentPortMode;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int wfdGetPortAttribi(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib);

			internal static wfdGetPortAttribi pwfdGetPortAttribi;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate float wfdGetPortAttribf(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib);

			internal static wfdGetPortAttribf pwfdGetPortAttribf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfdGetPortAttribiv(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, int count, int* value);

			internal static wfdGetPortAttribiv pwfdGetPortAttribiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfdGetPortAttribfv(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, int count, float* value);

			internal static wfdGetPortAttribfv pwfdGetPortAttribfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfdSetPortAttribi(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, int value);

			internal static wfdSetPortAttribi pwfdSetPortAttribi;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfdSetPortAttribf(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, float value);

			internal static wfdSetPortAttribf pwfdSetPortAttribf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfdSetPortAttribiv(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, int count, int* value);

			internal static wfdSetPortAttribiv pwfdSetPortAttribiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfdSetPortAttribfv(UInt32 device, UInt32 port, WFDPortConfigAttrib attrib, int count, float* value);

			internal static wfdSetPortAttribfv pwfdSetPortAttribfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfdBindPipelineToPort(UInt32 device, UInt32 port, UInt32 pipeline);

			internal static wfdBindPipelineToPort pwfdBindPipelineToPort;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wfdGetDisplayDataFormats(UInt32 device, UInt32 port, WFDDisplayDataFormat* format, int formatCount);

			internal static wfdGetDisplayDataFormats pwfdGetDisplayDataFormats;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wfdGetDisplayData(UInt32 device, UInt32 port, WFDDisplayDataFormat format, byte* data, int dataCount);

			internal static wfdGetDisplayData pwfdGetDisplayData;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wfdEnumeratePipelines(UInt32 device, int* pipelineIds, int pipelineIdsCount, int* filterList);

			internal static wfdEnumeratePipelines pwfdEnumeratePipelines;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wfdCreatePipeline(UInt32 device, int pipelineId, int* attribList);

			internal static wfdCreatePipeline pwfdCreatePipeline;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfdDestroyPipeline(UInt32 device, UInt32 pipeline);

			internal static wfdDestroyPipeline pwfdDestroyPipeline;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wfdCreateSourceFromImage(UInt32 device, UInt32 pipeline, IntPtr image, int* attribList);

			internal static wfdCreateSourceFromImage pwfdCreateSourceFromImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wfdCreateSourceFromStream(UInt32 device, UInt32 pipeline, UInt32 stream, int* attribList);

			internal static wfdCreateSourceFromStream pwfdCreateSourceFromStream;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfdDestroySource(UInt32 device, UInt32 source);

			internal static wfdDestroySource pwfdDestroySource;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wfdCreateMaskFromImage(UInt32 device, UInt32 pipeline, IntPtr image, int* attribList);

			internal static wfdCreateMaskFromImage pwfdCreateMaskFromImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wfdCreateMaskFromStream(UInt32 device, UInt32 pipeline, UInt32 stream, int* attribList);

			internal static wfdCreateMaskFromStream pwfdCreateMaskFromStream;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfdDestroyMask(UInt32 device, UInt32 mask);

			internal static wfdDestroyMask pwfdDestroyMask;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfdBindSourceToPipeline(UInt32 device, UInt32 pipeline, UInt32 source, WFDTransition transition, WFDRect* region);

			internal static wfdBindSourceToPipeline pwfdBindSourceToPipeline;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfdBindMaskToPipeline(UInt32 device, UInt32 pipeline, UInt32 mask, WFDTransition transition);

			internal static wfdBindMaskToPipeline pwfdBindMaskToPipeline;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int wfdGetPipelineAttribi(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib);

			internal static wfdGetPipelineAttribi pwfdGetPipelineAttribi;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate float wfdGetPipelineAttribf(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib);

			internal static wfdGetPipelineAttribf pwfdGetPipelineAttribf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfdGetPipelineAttribiv(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, int count, int* value);

			internal static wfdGetPipelineAttribiv pwfdGetPipelineAttribiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfdGetPipelineAttribfv(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, int count, float* value);

			internal static wfdGetPipelineAttribfv pwfdGetPipelineAttribfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfdSetPipelineAttribi(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, int value);

			internal static wfdSetPipelineAttribi pwfdSetPipelineAttribi;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfdSetPipelineAttribf(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, float value);

			internal static wfdSetPipelineAttribf pwfdSetPipelineAttribf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfdSetPipelineAttribiv(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, int count, int* value);

			internal static wfdSetPipelineAttribiv pwfdSetPipelineAttribiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfdSetPipelineAttribfv(UInt32 device, UInt32 pipeline, WFDPipelineConfigAttrib attrib, int count, float* value);

			internal static wfdSetPipelineAttribfv pwfdSetPipelineAttribfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wfdGetPipelineTransparency(UInt32 device, UInt32 pipeline, UInt32* trans, int transCount);

			internal static wfdGetPipelineTransparency pwfdGetPipelineTransparency;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfdSetPipelineTSColor(UInt32 device, UInt32 pipeline, WFDTSColorFormat colorFormat, int count, void* color);

			internal static wfdSetPipelineTSColor pwfdSetPipelineTSColor;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int wfdGetPipelineLayerOrder(UInt32 device, UInt32 port, UInt32 pipeline);

			internal static wfdGetPipelineLayerOrder pwfdGetPipelineLayerOrder;

		}
	}

}

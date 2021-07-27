/* 
 * Copyright (c) 2021 Mirko Brombin <send@mirko.pm>.
 * Copyright (c) 2021 Bottles Developers <https://github.com/bottlesdevs>.
 * 
 * This program is free software: you can redistribute it and/or modify  
 * it under the terms of the GNU General Public License as published by  
 * the Free Software Foundation, version 3.
 *
 * This program is distributed in the hope that it will be useful, but 
 * WITHOUT ANY WARRANTY; without even the implied warranty of 
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU 
 * General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License 
 * along with this program. If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;


namespace Bottles.LibraryBottles.Models
{
    public class Bottle
    {
        public enum Environments {
            Gaming,
            Software,
            Custom
        }
        public DateTime Creation { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Runner { get; set; }
        public Environments Environment { get; set; }
        public List<string> InstalledDependencies { get; set; }
        public List<Program> Programs { get; set; }
        public List<ExternalProgram> ExternalPrograms { get; set; }
        public List<DLLOverride> DLLOverrides { get; set; }
        public BottleParameters Parameters { get; set; }
        public uint State { get; set; }
        public bool UseVersioning { get; set; }
    }

    public class BottleParameters {
        public enum SyncTypes {
            System,
            Esync,
            Fsync
        }
        public bool AcoCompiler { get; set; }
        public bool DiscreteGPU { get; set; }
        public bool DXVK { get; set; }
        public string DXVKVersion { get; set; }
        public bool DXVKHUD { get; set; }
        public bool VKD3D { get; set; }
        public string VKD3DVersion { get; set; }
        public bool FixMeLogs { get; set; }
        public bool GameMode { get; set; }
        public bool PulseAudioLatency { get; set; }
        public SyncTypes Sync { get; set; }
        public bool VirtualDesktop { get; set; }
        public string VirtualDesktopResolution { get; set; }
    }
}
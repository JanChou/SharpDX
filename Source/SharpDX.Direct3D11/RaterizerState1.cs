﻿// Copyright (c) 2010-2012 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
#if DIRECTX11_1
using System;

namespace SharpDX.Direct3D11
{
    public partial class RasterizerState1
    {
        /// <summary>
        ///   Constructs a new <see cref = "T:SharpDX.Direct3D11.RasterizerState1" /> based on the specified description.
        /// </summary>
        /// <param name = "device">The device with which to associate the state object.</param>
        /// <param name = "description">The state description.</param>
        /// <returns>The newly created object.</returns>
        public RasterizerState1(Device1 device, RasterizerDescription1 description)
            : base(IntPtr.Zero)
        {
            device.CreateRasterizerState1(ref description, this);
        }

        /// <summary>
        ///   Constructs a new <see cref = "T:SharpDX.Direct3D11.RasterizerState1" /> based on the specified description.
        /// </summary>
        /// <param name = "device">The device with which to associate the state object.</param>
        /// <param name = "description">The state description.</param>
        /// <returns>The newly created object.</returns>
        public RasterizerState1(Device1 device, ref RasterizerDescription1 description)
            : base(IntPtr.Zero)
        {
            device.CreateRasterizerState1(ref description, this);
        }
    }
}
#endif
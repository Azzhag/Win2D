// Copyright (c) Microsoft Corporation. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may
// not use these files except in compliance with the License. You may obtain
// a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
// WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
// License for the specific language governing permissions and limitations
// under the License.

using Windows.UI;
using Windows.UI.Xaml.Controls;
using Microsoft.Graphics.Canvas;

namespace SimpleSample
{
    /// <summary>
    /// Clears the screen with BlanchedAlmond color
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Register our event handler that will draw onto the Canvas
            canvasControl.Draw += canvasControl_Draw;
        }

        void canvasControl_Draw(CanvasControl sender, CanvasDrawEventArgs args)
        {
            args.DrawingSession.Clear(Colors.CornflowerBlue);
            args.DrawingSession.DrawEllipse(190, 125, 140, 40, Colors.Black, 6);
            args.DrawingSession.DrawText("Hello, world!", 100, 100, Colors.Yellow);
        }
    }
}

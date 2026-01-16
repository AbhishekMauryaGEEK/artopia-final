# 🌌 AR Planet Simulator

**Real-time Augmented Reality Solar System with Interactive Controls and Speech Descriptions**

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Unity](https://img.shields.io/badge/Unity-2022.3-blue.svg)](https://unity.com/)
[![AR Foundation](https://img.shields.io/badge/AR_Foundation-5.1-green.svg)](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@5.1/)

## ✨ Features

- 🌍 **Realistic Planet Rotations** - Accurate orbital speeds matching real solar system
- 🎤 **Speech-to-Text Descriptions** - Audio narration for each planet's facts
- ⏯️ **Interactive Controls** - Play/pause/resume rotation with touch gestures
- 📱 **AR Plane Detection** - Planets appear anchored to real-world surfaces
- 🎨 **Smooth Animations** - 60fps performance on mid-range mobile devices
- 🔄 **Touch Interactions** - Rotate, stop, and resume individual planet motion

## 🛠️ Tech Stack
Core Framework: Unity 2022.3+
AR Engine: AR Foundation 5.1
Language: C# (.NET 4.x)
Rendering: Universal Render Pipeline (URP)
Audio: Unity Audio System + Text-to-Speech
Input: Touch Gestures + AR Raycasting
## 📱 Demo

**Download the AR app and point your camera at any flat surface to see the solar system come alive!**

[📥 Download APK](https://docs.google.com/uc?export=download&id=1RF2eOqNDCdWOQa4NLtWsA0-3hFpjR29E)

## 🎮 How to Use

1. **Launch the app** and grant camera permissions
2. **Point camera at flat surface** - AR plane will be detected automatically
3. **Tap to place solar system** - Sun and planets appear in AR space
4. **Touch any planet** to:
   - **Pause/Resume rotation** (tap again to toggle)
   - **Hear audio description** of the planet
5. **Pinch to zoom**, **drag to rotate view**

## 🚀 Core Features Implementation

### Realistic Rotation Physics
Planet Data (Real Rotation Speeds)
Planet	Rotation Period	Scale Factor	Audio Facts
Mercury	58.6 days	0.38x Earth	4 facts
Venus	243 days	0.95x Earth	5 facts
Earth	23h 56m	1.0x	6 facts
Mars	24h 37m	0.53x Earth	5 facts
Jupiter	9h 56m	11.2x Earth	7 facts
Saturn	10h 33m	9.5x Earth	6 facts
Uranus	17h 14m	4.0x Earth	5 facts
Neptune	16h 6m	3.9x Earth	5 facts
# Clone repository
git clone https://github.com/AbhishekMauryaGEEK/ar-planet-simulator.git
cd ar-planet-simulator

# Open in Unity Hub (2022.3+)
# Install AR Foundation 5.1 via Package Manager
# Build for Android/iOS
📱Supported Devices
Android: 8.0+ with ARCore support

iOS: 13.0+ with ARKit support

Minimum: 3GB RAM, OpenGL ES 3.0

🤝 Contributing
Fork the repository

Create feature branch (git checkout -b feature/planet-audio)

Commit changes (git commit -m 'Add Neptune audio facts')

Push to branch (git push origin feature/planet-audio)

Open Pull Request

📄 License
This project is licensed under the MIT License - see the LICENSE file for details.

🙏 Acknowledgments
Unity AR Foundation team for robust AR capabilities

NASA for accurate planetary rotation data

ABES Engineering College hackathon team

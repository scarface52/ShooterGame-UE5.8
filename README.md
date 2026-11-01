# ShooterGame for UE 5.8

An unofficial port of Epic Games' ShooterGame sample to Unreal Engine 5.8.

This repository contains the C++ source and project configuration only. The `Content` folder is not included; get it from the original [Shooter Game sample on Fab](https://www.fab.com/listings/316f0c15-cb37-4580-8670-b0b7c423165a).

## Status

The editor target builds for Win64 Development, and the project opens and passes map check without errors.

## Requirements

- Unreal Engine 5.8
- Visual Studio 2022 with the "Game development with C++" workload
- The original ShooterGame content

## Setup

1. Copy the `Content` folder from the original sample into the repository root.
2. Right-click `ShooterGame.uproject` and select "Generate Visual Studio project files".
3. Build `ShooterGameEditor` (Development Editor, Win64).
4. Open `ShooterGame.uproject`.

To build from the command line:

```powershell
& "C:\Program Files\Epic Games\UE_5.8\Engine\Build\BatchFiles\Build.bat" ShooterGameEditor Win64 Development -Project="$PWD\ShooterGame.uproject"
```

## License

ShooterGame belongs to Epic Games and is covered by the Unreal Engine EULA. See [NOTICE.md](NOTICE.md).

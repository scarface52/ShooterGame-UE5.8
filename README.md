# ShooterGame UE 5.8 Port

An unofficial, source-focused port of Epic Games' classic **ShooterGame** sample to Unreal Engine 5.8.

This repository contains the updated C++ source, project configuration, and build metadata. It intentionally does **not** redistribute the original `Content` directory. You must obtain the ShooterGame sample through an authorized source and supply those assets locally.

## Original project

The original **Shooter Game** sample is published free by Epic Games on Fab:

- [Shooter Game — official Fab listing](https://www.fab.com/listings/316f0c15-cb37-4580-8670-b0b7c423165a)

This repository is a community compatibility port, not a replacement for or official continuation of the original sample.

## Status

- `ShooterGameEditor` builds successfully for Win64 Development with Unreal Engine 5.8.
- The editor can load the project and complete map validation without map-check errors.
- Core gameplay source has been migrated to current UE APIs and module conventions.
- Steam/EOS deployment and packaged multiplayer builds have not yet been validated.

Known non-blocking asset warnings inherited from the older sample include legacy Matinee actors and missing references to `/Engine/EngineMeshes/Humanoid` in two skeleton assets. These assets are not included in this repository.

## Requirements

- Unreal Engine 5.8
- Visual Studio 2022 with the **Game development with C++** workload
- A legally obtained copy of the original ShooterGame sample content

## Setup

1. Add the [official Shooter Game sample](https://www.fab.com/listings/316f0c15-cb37-4580-8670-b0b7c423165a) to your Fab library and obtain its files through Epic's supported tools.
2. Copy the original sample's `Content` folder into the repository root. Keep it untracked unless you have reviewed the applicable licensing and repository-size implications.
3. Right-click `ShooterGame.uproject` and choose **Generate Visual Studio project files**, or use Unreal Build Tool.
4. Open the generated solution and build `ShooterGameEditor` for **Development Editor / Win64**.
5. Open `ShooterGame.uproject` in Unreal Engine 5.8.

Command-line build example:

```powershell
& "C:\Program Files\Epic Games\UE_5.8\Engine\Build\BatchFiles\Build.bat" ShooterGameEditor Win64 Development -Project="$PWD\ShooterGame.uproject"
```

## Porting work

The migration included target/build-system modernization, module dependency cleanup, header and include-path updates, and adaptation of obsolete engine APIs to their UE 5.8 equivalents. See [PORTING_NOTES.md](PORTING_NOTES.md) for a portfolio-oriented technical summary.

## Legal notice

ShooterGame is an Epic Games sample. The original sample code and assets remain subject to Epic Games' applicable terms, including the Unreal Engine End User License Agreement. This repository is not an official Epic Games project and does not grant additional rights to Epic-owned material. See [NOTICE.md](NOTICE.md).

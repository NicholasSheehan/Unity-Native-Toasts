# Changelog
All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [1.0.2] - 2020-04-15
### Changed
- Calls into Android were looking for instanced methods, whereas static methods needed to be called
- Split out the methods in Android out into two different methods

## [1.0.1] - 2020-04-15
### Changed
- Fixed `AndroidUnityNativeToastsAdapter.cs` still having the constructor for `AndroidUnityNativeSharingAdapter.cs` from when it was copied over 
- Fixed incorrect comment

## [1.0.0] - 2020-04-13
### This is the first release of *Unity-Native-Toasts*.

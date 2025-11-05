# Assorted vMix scripts

# Low-volume alerting script
vMix VB Script for low-volume alerting on main audio bus

This is a very quickly-assembled script designed to mimic the vMix low audio level warnings, but in a different manner. Hand-coded, no AI was used.

Whereas vMix's alerting puts a banner over the program and multiviewers, this uses a single title with multiple pages to create an alert.

# Usage:
- Add LowVolumeAlert.gtzip to vMix. This will be where you see your alerts. You can dedicate an output to it if that suits your purposes, but I generally just keep the input thumbnail visible.
- Add the script to vMix, and name it LowVolume. It can either be a local script, or a per-preset script.
- Add a web browser input pointing to http://127.0.0.1:8088/api/?Function=ScriptStart&Value=LowVolume - This will auto-start the script when you open vMix.

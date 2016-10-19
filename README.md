# INI Reader
C# Class similar to Java properties class for INI file.

### INI File Example
    # This is a comment
    host=192.168.0.1
    username=admin

### C# Code Example
    // Case 1
    var host = INIReader.GetProperties("host");
    
    // Case 2
    var properties = INIReader("settings.ini");
    var username = properties.getProperty("username");
    

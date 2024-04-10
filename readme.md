# Assimp-test

## .NET
1. Run `build.bat` or use `dotnet build` to build the project.
2. Run the program with model path as the argument.
    
Example:

        GLTFConverter.exe "path/to/your/model.obj"


## Python
1. Run `setup.bat` or `python -m pip install -r requirements.txt` to install the required packages.
2. Install assimp library using this [manual](https://github.com/assimp/assimp/blob/master/Build.md) and put the DLL to $PATH.
3. Run `python main.py` with model path as the argument.

Example:

        python main.py "path/to/your/model.obj"


### Output should be `output.glb` for both.
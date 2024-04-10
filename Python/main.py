import sys
import pyassimp

# Access individual arguments
if len(sys.argv) < 2:
    print("No arguments provided.")
    sys.exit(1)

path = sys.argv[1]


try:
    with pyassimp.load(path) as scene:
        pyassimp.export(scene, "output.glb", "glb2")
    print("Model exported as output.glb")
except:
    print("Model failed to export")
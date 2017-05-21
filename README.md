# VisualMutatorGUI

Simple GUI to visualize a results file from [VisualMutator](https://github.com/pavzaj/visualmutator/releases). The GUI will only show mutations that have the status `Live`. This tool was created because the graphical interface for VisualMutator built into Visual Studio is very unstable and it locks all your files to prevent you from editing. After you have saved the results you can use this tool without having VisualMutator open in Visual Studio.

## Usage

1. Open the VisualMutator dialog `View -> Other Windows -> VisualMutator`.
2. Start a new session and let it finish (this can take a very long time).
3. Click the `Save Results...` button and make sure to check both boxes (this **will** take a very long time):
   ![save results](https://i.imgur.com/3Zy2Ucy.png)
4. Start VisualMutatorGUI and load the saved results:

![screenshot](https://i.imgur.com/QL5bbGL.png)

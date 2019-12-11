# Why?
You can enable lightlayers in Unity HDRP (or LightLinking as it's called in Maya) when you want light to affect only certain objects and not all the objects in the scene. This is useful especially when you make film/animation using Unity. 

But when the object in question has a lot of meshes under it (like a complicated human character with 100s of sub-meshes) adding lightlayer to each mesh gets cumbersome since you have to select each mesh by hand and add them to the Rendering LayerMask. 

# What does this script do?
This script lets you set the LightLayer for all the Meshes under a parent object. That's about it. 
[![](https://i.imgur.com/ssijizx.gif)](https://i.imgur.com/ssijizx.gif)

# End result 

**Before** 

[![](https://i.imgur.com/l3iZzAT.png)](https://i.imgur.com/l3iZzAT.png)

**After** 

[![](https://i.imgur.com/x19IazK.png)](https://i.imgur.com/x19IazK.png)

#To enable LightLayers
[See this link](https://docs.unity3d.com/Packages/com.unity.render-pipelines.high-definition@6.9/manual/Light-Layers.html "See this link")

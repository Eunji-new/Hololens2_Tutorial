using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.SpatialAwareness;
using Microsoft.MixedReality.Toolkit.XRSDK.OpenXR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpatialMeshManage : MonoBehaviour
{

    private bool visibleSpatialMesh = true;

    public void ToggleVisbleSpatialMesh()
    {
        //OpenXRSpatialAwarenessMeshObserver
        //var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<OpenXRSpatialAwarenessMeshObserver>();

        if (visibleSpatialMesh)
        {
            // Set to not visible
            observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.None;
            visibleSpatialMesh = false;
        }
        else
        {
            // Set to visible and the Visble material
            observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.Visible;
            visibleSpatialMesh = true;
        }
    }

}

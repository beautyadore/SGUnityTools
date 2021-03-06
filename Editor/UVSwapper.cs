﻿/**************************************************************************
 * Copyright 2020 ArsMania
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
**************************************************************************/

using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SonicUnleashed.Editor
{
    public class UVSwapper : MonoBehaviour
    {
        [MenuItem("GameObject/Swap UV's", false, 0)]
        public static void SwapUVs(MenuCommand command)
        {
            var selected = Selection.gameObjects;

            foreach (var obj in selected)
            {
                var mesh = obj.GetComponent<MeshFilter>().sharedMesh;
                var uv1 = new List<Vector2>();
                mesh.GetUVs(1, uv1);
                mesh.SetUVs(2, uv1);
            }
        }
    }
}
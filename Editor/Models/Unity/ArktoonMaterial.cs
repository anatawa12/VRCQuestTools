﻿// <copyright file="ArktoonMaterial.cs" company="kurotu">
// Copyright (c) kurotu.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
// </copyright>

using KRT.VRCQuestTools.Utils;
using UnityEngine;

namespace KRT.VRCQuestTools.Models.Unity
{
    /// <summary>
    /// Represents arctoon-Shaders material.
    /// </summary>
    internal class ArktoonMaterial : StandardMaterial
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArktoonMaterial"/> class.
        /// </summary>
        /// <param name="material">Material.</param>
        internal ArktoonMaterial(Material material)
            : base(material)
        {
        }

        /// <inheritdoc/>
        internal override Texture2D GenerateToonLitImage()
        {
            var width = Material.mainTexture?.width ?? 4;
            var height = Material.mainTexture?.height ?? 4;

            using (var disposables = new CompositeDisposable())
            using (var baker = DisposableObject.New(Object.Instantiate(Material)))
            using (var dstTexture = DisposableObject.New(new RenderTexture(width, height, 0, RenderTextureFormat.ARGB32)))
            {
                baker.Object.shader = Material.shader.name.Contains("EmissiveFreak/")
                    ? Shader.Find("Hidden/VRCQuestTools/arktoon/EmissiveFreak")
                    : Shader.Find("Hidden/VRCQuestTools/arktoon/Opaque");
                foreach (var name in Material.GetTexturePropertyNames())
                {
                    var tex = AssetUtility.LoadUncompressedTexture(Material.GetTexture(name));
                    disposables.Add(DisposableObject.New(tex));
                    baker.Object.SetTexture(name, tex);
                }

                var main = baker.Object.mainTexture;

                // Remember active render texture
                var activeRenderTexture = RenderTexture.active;
                Graphics.Blit(main, dstTexture.Object, baker.Object);

                Texture2D outTexture = new Texture2D(width, height);
                outTexture.ReadPixels(new Rect(0, 0, width, height), 0, 0);
                outTexture.Apply();

                // Restore active render texture
                RenderTexture.active = activeRenderTexture;
                return outTexture;
            }
        }
    }
}

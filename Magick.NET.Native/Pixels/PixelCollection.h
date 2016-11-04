//=================================================================================================
// Copyright 2013-2016 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================
#pragma once

MAGICK_NET_EXPORT CacheView *PixelCollection_Create(const Image *, ExceptionInfo **);

MAGICK_NET_EXPORT void PixelCollection_Dispose(CacheView *);

MAGICK_NET_EXPORT const Quantum *PixelCollection_GetArea(const CacheView *, const size_t, const size_t, const size_t, const size_t, ExceptionInfo **);

MAGICK_NET_EXPORT void PixelCollection_SetArea(CacheView *, const size_t, const size_t, const size_t, const size_t, const Quantum *, const size_t, ExceptionInfo **);

MAGICK_NET_EXPORT unsigned char *PixelCollection_ToByteArray(const CacheView *, const size_t, const size_t, const size_t, const size_t, const char *, ExceptionInfo **);

MAGICK_NET_EXPORT unsigned short *PixelCollection_ToShortArray(const CacheView *, const size_t, const size_t, const size_t, const size_t, const char *, ExceptionInfo **);
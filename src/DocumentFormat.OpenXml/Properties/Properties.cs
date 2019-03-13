﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Resources;
using System.Runtime.CompilerServices;

// For testing
[assembly: InternalsVisibleTo("DocumentFormat.OpenXml.Tests, Publickey=002400000480000094000000060200000024000052534131000400000100010061d8931836c82bf25ca6b773dfd6e7b3ab4e43fba60cf4a86347170373415a165ccc40da3da4a52163822db9fa91f15828236d32d6a9fe754859f10d1f8262646c1f3fb6b4348123f14d733db0ff11c3198b7cf56caaebbf14563990446a6c32aff36d5a7097194294c127fe3cdf9f2609daae5f4daf26f8b6227f203d2a8bbf")]
[assembly: InternalsVisibleTo("DocumentFormat.OpenXml.Packaging.Tests, Publickey=002400000480000094000000060200000024000052534131000400000100010061d8931836c82bf25ca6b773dfd6e7b3ab4e43fba60cf4a86347170373415a165ccc40da3da4a52163822db9fa91f15828236d32d6a9fe754859f10d1f8262646c1f3fb6b4348123f14d733db0ff11c3198b7cf56caaebbf14563990446a6c32aff36d5a7097194294c127fe3cdf9f2609daae5f4daf26f8b6227f203d2a8bbf")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2,PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7")]
[assembly: InternalsVisibleTo("DocumentFormat.OpenXml.Benchmarks, PublicKey=002400000480000094000000060200000024000052534131000400000100010061d8931836c82bf25ca6b773dfd6e7b3ab4e43fba60cf4a86347170373415a165ccc40da3da4a52163822db9fa91f15828236d32d6a9fe754859f10d1f8262646c1f3fb6b4348123f14d733db0ff11c3198b7cf56caaebbf14563990446a6c32aff36d5a7097194294c127fe3cdf9f2609daae5f4daf26f8b6227f203d2a8bbf")]
[assembly: InternalsVisibleTo("DocumentFormat.OpenXml.Framework.Tests, PublicKey=002400000480000094000000060200000024000052534131000400000100010061d8931836c82bf25ca6b773dfd6e7b3ab4e43fba60cf4a86347170373415a165ccc40da3da4a52163822db9fa91f15828236d32d6a9fe754859f10d1f8262646c1f3fb6b4348123f14d733db0ff11c3198b7cf56caaebbf14563990446a6c32aff36d5a7097194294c127fe3cdf9f2609daae5f4daf26f8b6227f203d2a8bbf")]

// For schema generation. Right now, some aspects only work on certain platforms, so we only expose internals on those platforms
#if FEATURE_SCHEMA_GENERATOR
[assembly: InternalsVisibleTo("DocumentFormat.OpenXml.Framework, Publickey=002400000480000094000000060200000024000052534131000400000100010061d8931836c82bf25ca6b773dfd6e7b3ab4e43fba60cf4a86347170373415a165ccc40da3da4a52163822db9fa91f15828236d32d6a9fe754859f10d1f8262646c1f3fb6b4348123f14d733db0ff11c3198b7cf56caaebbf14563990446a6c32aff36d5a7097194294c127fe3cdf9f2609daae5f4daf26f8b6227f203d2a8bbf")]
[assembly: InternalsVisibleTo("DomGenV3, Publickey=002400000480000094000000060200000024000052534131000400000100010061d8931836c82bf25ca6b773dfd6e7b3ab4e43fba60cf4a86347170373415a165ccc40da3da4a52163822db9fa91f15828236d32d6a9fe754859f10d1f8262646c1f3fb6b4348123f14d733db0ff11c3198b7cf56caaebbf14563990446a6c32aff36d5a7097194294c127fe3cdf9f2609daae5f4daf26f8b6227f203d2a8bbf")]
[assembly: InternalsVisibleTo("SchemaProcessor, Publickey=002400000480000094000000060200000024000052534131000400000100010061d8931836c82bf25ca6b773dfd6e7b3ab4e43fba60cf4a86347170373415a165ccc40da3da4a52163822db9fa91f15828236d32d6a9fe754859f10d1f8262646c1f3fb6b4348123f14d733db0ff11c3198b7cf56caaebbf14563990446a6c32aff36d5a7097194294c127fe3cdf9f2609daae5f4daf26f8b6227f203d2a8bbf")]
[assembly: InternalsVisibleTo("SchematronGenerator, Publickey=002400000480000094000000060200000024000052534131000400000100010061d8931836c82bf25ca6b773dfd6e7b3ab4e43fba60cf4a86347170373415a165ccc40da3da4a52163822db9fa91f15828236d32d6a9fe754859f10d1f8262646c1f3fb6b4348123f14d733db0ff11c3198b7cf56caaebbf14563990446a6c32aff36d5a7097194294c127fe3cdf9f2609daae5f4daf26f8b6227f203d2a8bbf")]
[assembly: InternalsVisibleTo("SdbBuilder, Publickey=002400000480000094000000060200000024000052534131000400000100010061d8931836c82bf25ca6b773dfd6e7b3ab4e43fba60cf4a86347170373415a165ccc40da3da4a52163822db9fa91f15828236d32d6a9fe754859f10d1f8262646c1f3fb6b4348123f14d733db0ff11c3198b7cf56caaebbf14563990446a6c32aff36d5a7097194294c127fe3cdf9f2609daae5f4daf26f8b6227f203d2a8bbf")]
[assembly: InternalsVisibleTo("SemanticConstraintRegGen, Publickey=002400000480000094000000060200000024000052534131000400000100010061d8931836c82bf25ca6b773dfd6e7b3ab4e43fba60cf4a86347170373415a165ccc40da3da4a52163822db9fa91f15828236d32d6a9fe754859f10d1f8262646c1f3fb6b4348123f14d733db0ff11c3198b7cf56caaebbf14563990446a6c32aff36d5a7097194294c127fe3cdf9f2609daae5f4daf26f8b6227f203d2a8bbf")]
#endif

[assembly: CLSCompliant(true)]

[assembly: NeutralResourcesLanguage("en")]

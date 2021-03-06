﻿using System.Runtime.CompilerServices;

// Unit testing internal methods in VS2017 .Net Standard library
// https://stackoverflow.com/a/42235577/83861
[assembly: InternalsVisibleTo( "NScrape.Test.Framework, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b331efdfbf69ccecb96a9b189a418916dfd4a3df09432258be4ed51c4409af2f42b2cca89331ef319c0c478ebbca4e83042c958d4a61fc04391f5fd92514e741a9c09dbdd3e55dd04237f9b96c5c6e9af7fe96a72f9a9b66cb0cc99cda4ba3f53ffb8335e42558b605f04692208f0a7893569390bb92a21843eda2b64b698c94" )]
[assembly: InternalsVisibleTo( "NScrape.Test.Core, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b331efdfbf69ccecb96a9b189a418916dfd4a3df09432258be4ed51c4409af2f42b2cca89331ef319c0c478ebbca4e83042c958d4a61fc04391f5fd92514e741a9c09dbdd3e55dd04237f9b96c5c6e9af7fe96a72f9a9b66cb0cc99cda4ba3f53ffb8335e42558b605f04692208f0a7893569390bb92a21843eda2b64b698c94" )]

namespace NScrape {
	/// <summary>
	/// The <b>NScrape</b> namespace contains the types that provide core framework functionality. 
	/// </summary>
	internal class NamespaceDoc {
		// This class is used to define namespace comments for Sandcastle Help File Builder
		private NamespaceDoc() { }
	}
}

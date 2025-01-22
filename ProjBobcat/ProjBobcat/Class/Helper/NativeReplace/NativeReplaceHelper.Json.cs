﻿namespace ProjBobcat.Class.Helper.NativeReplace;

public static partial class NativeReplaceHelper
{
    const string ReplaceDicJson = """
                                  {
                                    "linux-arm64": {
                                      "org.lwjgl:lwjgl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2.jar",
                                            "sha1": "4421d94af68e35dcaa31737a6fc59136a1e61b94",
                                            "size": 786196
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "8bd89332c90a90e6bc4aa997a25c05b7db02c90a",
                                            "size": 90795
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2.jar",
                                            "sha1": "877e17e39ebcd58a9c956dc3b5b777813de0873a",
                                            "size": 43233
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "5249f18a9ae20ea86c5816bc3107a888ce7a17d2",
                                            "size": 206402
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2.jar",
                                            "sha1": "ae5357ed6d934546d3533993ea84c0cfb75eed95",
                                            "size": 108230
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "22408980cc579709feaf9acb807992d3ebcf693f",
                                            "size": 590865
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2.jar",
                                            "sha1": "ee8e95be0b438602038bc1f02dc5e3d011b1b216",
                                            "size": 928871
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "bb9eb56da6d1d549d6a767218e675e36bc568eb9",
                                            "size": 58627
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2.jar",
                                            "sha1": "757920418805fb90bfebb3d46b1d9e7669fca2eb",
                                            "size": 135828
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "bc49e64bae0f7ff103a312ee8074a34c4eb034c7",
                                            "size": 120168
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2.jar",
                                            "sha1": "a2550795014d622b686e9caac50b14baa87d2c70",
                                            "size": 118874
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "11a380c37b0f03cb46db235e064528f84d736ff7",
                                            "size": 207419
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2.jar",
                                            "sha1": "9f65c248dd77934105274fcf8351abb75b34327c",
                                            "size": 13404
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "93f8c5bc1984963cd79109891fb5a9d1e580373e",
                                            "size": 43381
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2.jar",
                                            "sha1": "4421d94af68e35dcaa31737a6fc59136a1e61b94",
                                            "size": 786196
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "8bd89332c90a90e6bc4aa997a25c05b7db02c90a",
                                            "size": 90795
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2.jar",
                                            "sha1": "877e17e39ebcd58a9c956dc3b5b777813de0873a",
                                            "size": 43233
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "5249f18a9ae20ea86c5816bc3107a888ce7a17d2",
                                            "size": 206402
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2.jar",
                                            "sha1": "ae5357ed6d934546d3533993ea84c0cfb75eed95",
                                            "size": 108230
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "22408980cc579709feaf9acb807992d3ebcf693f",
                                            "size": 590865
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2.jar",
                                            "sha1": "ee8e95be0b438602038bc1f02dc5e3d011b1b216",
                                            "size": 928871
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "bb9eb56da6d1d549d6a767218e675e36bc568eb9",
                                            "size": 58627
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2.jar",
                                            "sha1": "757920418805fb90bfebb3d46b1d9e7669fca2eb",
                                            "size": 135828
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "bc49e64bae0f7ff103a312ee8074a34c4eb034c7",
                                            "size": 120168
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2.jar",
                                            "sha1": "a2550795014d622b686e9caac50b14baa87d2c70",
                                            "size": 118874
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "11a380c37b0f03cb46db235e064528f84d736ff7",
                                            "size": 207419
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2.jar",
                                            "sha1": "9f65c248dd77934105274fcf8351abb75b34327c",
                                            "size": 13404
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "93f8c5bc1984963cd79109891fb5a9d1e580373e",
                                            "size": 43381
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2.jar",
                                            "sha1": "4421d94af68e35dcaa31737a6fc59136a1e61b94",
                                            "size": 786196
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "8bd89332c90a90e6bc4aa997a25c05b7db02c90a",
                                            "size": 90795
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2.jar",
                                            "sha1": "877e17e39ebcd58a9c956dc3b5b777813de0873a",
                                            "size": 43233
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "5249f18a9ae20ea86c5816bc3107a888ce7a17d2",
                                            "size": 206402
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2.jar",
                                            "sha1": "ae5357ed6d934546d3533993ea84c0cfb75eed95",
                                            "size": 108230
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "22408980cc579709feaf9acb807992d3ebcf693f",
                                            "size": 590865
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2.jar",
                                            "sha1": "ee8e95be0b438602038bc1f02dc5e3d011b1b216",
                                            "size": 928871
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "bb9eb56da6d1d549d6a767218e675e36bc568eb9",
                                            "size": 58627
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2.jar",
                                            "sha1": "757920418805fb90bfebb3d46b1d9e7669fca2eb",
                                            "size": 135828
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "bc49e64bae0f7ff103a312ee8074a34c4eb034c7",
                                            "size": 120168
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2.jar",
                                            "sha1": "a2550795014d622b686e9caac50b14baa87d2c70",
                                            "size": 118874
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "11a380c37b0f03cb46db235e064528f84d736ff7",
                                            "size": 207419
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2.jar",
                                            "sha1": "9f65c248dd77934105274fcf8351abb75b34327c",
                                            "size": 13404
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "93f8c5bc1984963cd79109891fb5a9d1e580373e",
                                            "size": 43381
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.1": {
                                        "name": "org.lwjgl:lwjgl:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2.jar",
                                            "sha1": "4421d94af68e35dcaa31737a6fc59136a1e61b94",
                                            "size": 786196
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "8bd89332c90a90e6bc4aa997a25c05b7db02c90a",
                                            "size": 90795
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2.jar",
                                            "sha1": "877e17e39ebcd58a9c956dc3b5b777813de0873a",
                                            "size": 43233
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "5249f18a9ae20ea86c5816bc3107a888ce7a17d2",
                                            "size": 206402
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2.jar",
                                            "sha1": "ae5357ed6d934546d3533993ea84c0cfb75eed95",
                                            "size": 108230
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "22408980cc579709feaf9acb807992d3ebcf693f",
                                            "size": 590865
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2.jar",
                                            "sha1": "ee8e95be0b438602038bc1f02dc5e3d011b1b216",
                                            "size": 928871
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "bb9eb56da6d1d549d6a767218e675e36bc568eb9",
                                            "size": 58627
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2.jar",
                                            "sha1": "757920418805fb90bfebb3d46b1d9e7669fca2eb",
                                            "size": 135828
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "bc49e64bae0f7ff103a312ee8074a34c4eb034c7",
                                            "size": 120168
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2.jar",
                                            "sha1": "a2550795014d622b686e9caac50b14baa87d2c70",
                                            "size": 118874
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "11a380c37b0f03cb46db235e064528f84d736ff7",
                                            "size": 207419
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2.jar",
                                            "sha1": "9f65c248dd77934105274fcf8351abb75b34327c",
                                            "size": 13404
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "93f8c5bc1984963cd79109891fb5a9d1e580373e",
                                            "size": 43381
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "8bd89332c90a90e6bc4aa997a25c05b7db02c90a",
                                            "size": 90795
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "5249f18a9ae20ea86c5816bc3107a888ce7a17d2",
                                            "size": 206402
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "22408980cc579709feaf9acb807992d3ebcf693f",
                                            "size": 590865
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "bb9eb56da6d1d549d6a767218e675e36bc568eb9",
                                            "size": 58627
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "bc49e64bae0f7ff103a312ee8074a34c4eb034c7",
                                            "size": 120168
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "11a380c37b0f03cb46db235e064528f84d736ff7",
                                            "size": 207419
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.2:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2-natives-linux-arm64.jar",
                                            "sha1": "93f8c5bc1984963cd79109891fb5a9d1e580373e",
                                            "size": 43381
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl:3.3.3:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.3/lwjgl-3.3.3-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.3/lwjgl-3.3.3-natives-linux-arm64.jar",
                                            "sha1": "f35d8b6ffe1ac1e3a5eb1d4e33de80f044ad5fd8",
                                            "size": 91294
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.3:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.3/lwjgl-jemalloc-3.3.3-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.3/lwjgl-jemalloc-3.3.3-natives-linux-arm64.jar",
                                            "sha1": "eff8b86798191192fe2cba2dc2776109f30c239d",
                                            "size": 209315
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.3:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.3/lwjgl-openal-3.3.3-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.3/lwjgl-openal-3.3.3-natives-linux-arm64.jar",
                                            "sha1": "ad8f302118a65bb8d615f8a2a680db58fb8f835e",
                                            "size": 592963
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.3:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.3/lwjgl-opengl-3.3.3-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.3/lwjgl-opengl-3.3.3-natives-linux-arm64.jar",
                                            "sha1": "2096f6b94b2d68745d858fbfe53aacf5f0c8074c",
                                            "size": 58625
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.3:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.3/lwjgl-glfw-3.3.3-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.3/lwjgl-glfw-3.3.3-natives-linux-arm64.jar",
                                            "sha1": "492a0f11f85b85899a6568f07511160c1b87cd38",
                                            "size": 122159
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.3:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.3/lwjgl-stb-3.3.3-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.3/lwjgl-stb-3.3.3-natives-linux-arm64.jar",
                                            "sha1": "ddc177afc2be1ee8d93684b11363b80589a13fe1",
                                            "size": 207418
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.3:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.3/lwjgl-tinyfd-3.3.3-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.3/lwjgl-tinyfd-3.3.3-natives-linux-arm64.jar",
                                            "sha1": "2823a8c955c758d0954d282888075019ef99cec7",
                                            "size": 43864
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-freetype:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-freetype:3.3.3:natives-linux-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-freetype/3.3.3/lwjgl-freetype-3.3.3-natives-linux-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-freetype/3.3.3/lwjgl-freetype-3.3.3-natives-linux-arm64.jar",
                                            "sha1": "498965aac06c4a0d42df1fbef6bacd05bde7f974",
                                            "size": 1093516
                                          }
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.0:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-arm64": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3/lwjgl2-natives-2.9.3-linux-arm64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-linux-arm64/lwjgl2-natives-2.9.3-linux-arm64.jar",
                                              "sha1": "c47df34b6a0414b2d9972f602d0c85191129d69c",
                                              "size": 7346768
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-arm64"
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.1:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-arm64": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3/lwjgl2-natives-2.9.3-linux-arm64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-linux-arm64/lwjgl2-natives-2.9.3-linux-arm64.jar",
                                              "sha1": "c47df34b6a0414b2d9972f602d0c85191129d69c",
                                              "size": 7346768
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-arm64"
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.4-nightly-20150209:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-arm64": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3/lwjgl2-natives-2.9.3-linux-arm64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-linux-arm64/lwjgl2-natives-2.9.3-linux-arm64.jar",
                                              "sha1": "c47df34b6a0414b2d9972f602d0c85191129d69c",
                                              "size": 7346768
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-arm64"
                                        }
                                      },
                                      "net.java.jinput:jinput-platform:2.0.5:natives": null,
                                      "com.mojang:text2speech:1.10.3:natives": null,
                                      "com.mojang:text2speech:1.11.3:natives": null,
                                      "com.mojang:text2speech:1.12.4:natives": null,
                                      "com.mojang:text2speech:1.13.9:natives-linux": null
                                    },
                                    "linux-arm32": {
                                      "org.lwjgl:lwjgl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.2.3/lwjgl-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.2.3/lwjgl-3.2.3.jar",
                                            "sha1": "17a59ba0fe8d474ec9dbe0d5db40d2cfe59c4c08",
                                            "size": 552997
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.2.3/lwjgl-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.2.3/lwjgl-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "3180d363040744dfe0c6a0dd5d018cedae476e9a",
                                            "size": 53035
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.2.3/lwjgl-jemalloc-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.2.3/lwjgl-jemalloc-3.2.3.jar",
                                            "sha1": "b6fd0932171ba3f2eaa4547beddca3a3e645342d",
                                            "size": 34130
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.2.3/lwjgl-jemalloc-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.2.3/lwjgl-jemalloc-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "d7e5cecbf045b7b7863343273ffea94e0e2f6994",
                                            "size": 137847
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-openal:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.2.3/lwjgl-openal-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.2.3/lwjgl-openal-3.2.3.jar",
                                            "sha1": "106742e805803ab9eab8e343f0fb31a3d263903c",
                                            "size": 79432
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.2.3/lwjgl-openal-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.2.3/lwjgl-openal-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "5c30ef08c829252e542f9fbc04772d51013326c5",
                                            "size": 552314
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.2.3/lwjgl-opengl-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.2.3/lwjgl-opengl-3.2.3.jar",
                                            "sha1": "bdd534a323d0c8f54969b95e424b6ac8984f7d6e",
                                            "size": 936589
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.2.3/lwjgl-opengl-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.2.3/lwjgl-opengl-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "4925362a5f2412cb6467e6d6c6de26b9e1ccfc71",
                                            "size": 58594
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.2.3/lwjgl-glfw-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.2.3/lwjgl-glfw-3.2.3.jar",
                                            "sha1": "5e520d5c290c8b012545a8d34fa5db5ab051ea53",
                                            "size": 107999
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.2.3/lwjgl-glfw-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.2.3/lwjgl-glfw-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "aab1a5a1e21eca87f4acd5ba055f6bfd5d90951c",
                                            "size": 138698
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-stb:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.2.3/lwjgl-stb-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.2.3/lwjgl-stb-3.2.3.jar",
                                            "sha1": "40eccaa4fa86fc815f2e17946a392fb5fdcc286a",
                                            "size": 104049
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.2.3/lwjgl-stb-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.2.3/lwjgl-stb-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "f28dc1e73025cf699a2cdd4f6db7964ed357ce50",
                                            "size": 146890
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.2.3/lwjgl-tinyfd-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.2.3/lwjgl-tinyfd-3.2.3.jar",
                                            "sha1": "d5edf89c7b6ca1ea20865a6ba0a09bfc5efb29c1",
                                            "size": 6392
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.2.3/lwjgl-tinyfd-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.2.3/lwjgl-tinyfd-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "b3ad16cb0e4c1307bf3d1ecb29559e18a4f8633c",
                                            "size": 38752
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.2.3/lwjgl-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.2.3/lwjgl-3.2.3.jar",
                                            "sha1": "17a59ba0fe8d474ec9dbe0d5db40d2cfe59c4c08",
                                            "size": 552997
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.2.3/lwjgl-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.2.3/lwjgl-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "3180d363040744dfe0c6a0dd5d018cedae476e9a",
                                            "size": 53035
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.2.3/lwjgl-jemalloc-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.2.3/lwjgl-jemalloc-3.2.3.jar",
                                            "sha1": "b6fd0932171ba3f2eaa4547beddca3a3e645342d",
                                            "size": 34130
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.2.3/lwjgl-jemalloc-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.2.3/lwjgl-jemalloc-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "d7e5cecbf045b7b7863343273ffea94e0e2f6994",
                                            "size": 137847
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-openal:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.2.3/lwjgl-openal-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.2.3/lwjgl-openal-3.2.3.jar",
                                            "sha1": "106742e805803ab9eab8e343f0fb31a3d263903c",
                                            "size": 79432
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.2.3/lwjgl-openal-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.2.3/lwjgl-openal-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "5c30ef08c829252e542f9fbc04772d51013326c5",
                                            "size": 552314
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.2.3/lwjgl-opengl-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.2.3/lwjgl-opengl-3.2.3.jar",
                                            "sha1": "bdd534a323d0c8f54969b95e424b6ac8984f7d6e",
                                            "size": 936589
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.2.3/lwjgl-opengl-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.2.3/lwjgl-opengl-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "4925362a5f2412cb6467e6d6c6de26b9e1ccfc71",
                                            "size": 58594
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.2.3/lwjgl-glfw-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.2.3/lwjgl-glfw-3.2.3.jar",
                                            "sha1": "5e520d5c290c8b012545a8d34fa5db5ab051ea53",
                                            "size": 107999
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.2.3/lwjgl-glfw-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.2.3/lwjgl-glfw-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "aab1a5a1e21eca87f4acd5ba055f6bfd5d90951c",
                                            "size": 138698
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-stb:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.2.3/lwjgl-stb-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.2.3/lwjgl-stb-3.2.3.jar",
                                            "sha1": "40eccaa4fa86fc815f2e17946a392fb5fdcc286a",
                                            "size": 104049
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.2.3/lwjgl-stb-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.2.3/lwjgl-stb-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "f28dc1e73025cf699a2cdd4f6db7964ed357ce50",
                                            "size": 146890
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.2.3/lwjgl-tinyfd-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.2.3/lwjgl-tinyfd-3.2.3.jar",
                                            "sha1": "d5edf89c7b6ca1ea20865a6ba0a09bfc5efb29c1",
                                            "size": 6392
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.2.3/lwjgl-tinyfd-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.2.3/lwjgl-tinyfd-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "b3ad16cb0e4c1307bf3d1ecb29559e18a4f8633c",
                                            "size": 38752
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.2.3/lwjgl-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.2.3/lwjgl-3.2.3.jar",
                                            "sha1": "17a59ba0fe8d474ec9dbe0d5db40d2cfe59c4c08",
                                            "size": 552997
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.2.3/lwjgl-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.2.3/lwjgl-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "3180d363040744dfe0c6a0dd5d018cedae476e9a",
                                            "size": 53035
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.2.3/lwjgl-jemalloc-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.2.3/lwjgl-jemalloc-3.2.3.jar",
                                            "sha1": "b6fd0932171ba3f2eaa4547beddca3a3e645342d",
                                            "size": 34130
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.2.3/lwjgl-jemalloc-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.2.3/lwjgl-jemalloc-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "d7e5cecbf045b7b7863343273ffea94e0e2f6994",
                                            "size": 137847
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-openal:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.2.3/lwjgl-openal-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.2.3/lwjgl-openal-3.2.3.jar",
                                            "sha1": "106742e805803ab9eab8e343f0fb31a3d263903c",
                                            "size": 79432
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.2.3/lwjgl-openal-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.2.3/lwjgl-openal-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "5c30ef08c829252e542f9fbc04772d51013326c5",
                                            "size": 552314
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.2.3/lwjgl-opengl-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.2.3/lwjgl-opengl-3.2.3.jar",
                                            "sha1": "bdd534a323d0c8f54969b95e424b6ac8984f7d6e",
                                            "size": 936589
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.2.3/lwjgl-opengl-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.2.3/lwjgl-opengl-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "4925362a5f2412cb6467e6d6c6de26b9e1ccfc71",
                                            "size": 58594
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.2.3/lwjgl-glfw-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.2.3/lwjgl-glfw-3.2.3.jar",
                                            "sha1": "5e520d5c290c8b012545a8d34fa5db5ab051ea53",
                                            "size": 107999
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.2.3/lwjgl-glfw-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.2.3/lwjgl-glfw-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "aab1a5a1e21eca87f4acd5ba055f6bfd5d90951c",
                                            "size": 138698
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-stb:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.2.3/lwjgl-stb-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.2.3/lwjgl-stb-3.2.3.jar",
                                            "sha1": "40eccaa4fa86fc815f2e17946a392fb5fdcc286a",
                                            "size": 104049
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.2.3/lwjgl-stb-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.2.3/lwjgl-stb-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "f28dc1e73025cf699a2cdd4f6db7964ed357ce50",
                                            "size": 146890
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.2.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.2.3/lwjgl-tinyfd-3.2.3.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.2.3/lwjgl-tinyfd-3.2.3.jar",
                                            "sha1": "d5edf89c7b6ca1ea20865a6ba0a09bfc5efb29c1",
                                            "size": 6392
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.2.3:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.2.3/lwjgl-tinyfd-3.2.3-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.2.3/lwjgl-tinyfd-3.2.3-natives-linux-arm32.jar",
                                            "sha1": "b3ad16cb0e4c1307bf3d1ecb29559e18a4f8633c",
                                            "size": 38752
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl:3.3.1:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1-natives-linux-arm32.jar",
                                            "sha1": "41a3c1dd15d6b964eb8196dde69720a3e3e5e969",
                                            "size": 82374
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.1:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1-natives-linux-arm32.jar",
                                            "sha1": "a96a6d6cb3876d7813fcee53c3c24f246aeba3b3",
                                            "size": 136157
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.1:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1-natives-linux-arm32.jar",
                                            "sha1": "ffbe35d7fa5ec9b7eca136a7c71f24d4025a510b",
                                            "size": 400129
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.1:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1-natives-linux-arm32.jar",
                                            "sha1": "e3550fa91097fd56e361b4370fa822220fef3595",
                                            "size": 58474
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.1:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1-natives-linux-arm32.jar",
                                            "sha1": "816d935933f2dd743074c4e717cc25b55720f294",
                                            "size": 104027
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.1:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1-natives-linux-arm32.jar",
                                            "sha1": "b08226bab162c06ae69337d8a1b0ee0a3fdf0b90",
                                            "size": 153889
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.1:natives-linux-arm32",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1-natives-linux-arm32.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1-natives-linux-arm32.jar",
                                            "sha1": "d53d331e859217a61298fcbcf8d79137f3df345c",
                                            "size": 48061
                                          }
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.0:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-arm32": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3/lwjgl2-natives-2.9.3-linux-arm32.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-linux-arm32/lwjgl2-natives-2.9.3-linux-arm32.jar",
                                              "sha1": "b3017961cf4ff2ce189b64903e52025a88ed9229",
                                              "size": 580670
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-arm32"
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.1:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-arm32": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3/lwjgl2-natives-2.9.3-linux-arm32.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-linux-arm32/lwjgl2-natives-2.9.3-linux-arm32.jar",
                                              "sha1": "b3017961cf4ff2ce189b64903e52025a88ed9229",
                                              "size": 580670
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-arm32"
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.4-nightly-20150209:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-arm32": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3/lwjgl2-natives-2.9.3-linux-arm32.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-linux-arm32/lwjgl2-natives-2.9.3-linux-arm32.jar",
                                              "sha1": "b3017961cf4ff2ce189b64903e52025a88ed9229",
                                              "size": 580670
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-arm32"
                                        }
                                      },
                                      "net.java.jinput:jinput-platform:2.0.5:natives": null,
                                      "com.mojang:text2speech:1.10.3:natives": null,
                                      "com.mojang:text2speech:1.11.3:natives": null,
                                      "com.mojang:text2speech:1.12.4:natives": null,
                                      "com.mojang:text2speech:1.13.9:natives-linux": null
                                    },
                                    "linux-mips64el": {
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.0:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3-rc2",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-mips64el": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3-rc2/lwjgl2-natives-2.9.3-rc2-linux-mips64el.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-rc2-linux-mips64el/lwjgl2-natives-2.9.3-rc2-linux-mips64el.jar",
                                              "sha1": "8e96ae0b3ca2b566d4aa1ef737f1a11fde34636c",
                                              "size": 947858
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-mips64el"
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.1:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3-rc2",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-mips64el": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3-rc2/lwjgl2-natives-2.9.3-rc2-linux-mips64el.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-rc2-linux-mips64el/lwjgl2-natives-2.9.3-rc2-linux-mips64el.jar",
                                              "sha1": "8e96ae0b3ca2b566d4aa1ef737f1a11fde34636c",
                                              "size": 947858
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-mips64el"
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.4-nightly-20150209:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3-rc2",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-mips64el": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3-rc2/lwjgl2-natives-2.9.3-rc2-linux-mips64el.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-rc2-linux-mips64el/lwjgl2-natives-2.9.3-rc2-linux-mips64el.jar",
                                              "sha1": "8e96ae0b3ca2b566d4aa1ef737f1a11fde34636c",
                                              "size": 947858
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-mips64el"
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "sha1": "ae58664f88e18a9bb2c77b063833ca7aaec484cb",
                                            "size": 724243
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.1.6:natives": {
                                        "name": "org.glavo.hmcl:lwjgl3-natives:3.3.1-rc2",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-mips64el": {
                                              "path": "org/glavo/hmcl/lwjgl3-natives/3.3.1-rc2/lwjgl3-natives-3.3.1-rc2-linux-mips64el.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl3-natives/3.3.1-rc2-linux-mips64el/lwjgl3-natives-3.3.1-rc2-linux-mips64el.jar",
                                              "sha1": "babec61846d8feb7a60cce1c9909281b1a3e0640",
                                              "size": 2464146
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-mips64el"
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "sha1": "a817bcf213db49f710603677457567c37d53e103",
                                            "size": 36601
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl-openal:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "sha1": "2623a6b8ae1dfcd880738656a9f0243d2e6840bd",
                                            "size": 88237
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl-opengl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "sha1": "831a5533a21a5f4f81bbc51bb13e9899319b5411",
                                            "size": 921563
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl-glfw:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "sha1": "cbac1b8d30cb4795149c1ef540f912671a8616d0",
                                            "size": 128801
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl-stb:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "sha1": "b119297cf8ed01f247abe8685857f8e7fcf5980f",
                                            "size": 112380
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "sha1": "0ff1914111ef2e3e0110ef2dabc8d8cdaad82347",
                                            "size": 6767
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "sha1": "ae58664f88e18a9bb2c77b063833ca7aaec484cb",
                                            "size": 724243
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.1:natives": {
                                        "name": "org.glavo.hmcl:lwjgl3-natives:3.3.1-rc2",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-mips64el": {
                                              "path": "org/glavo/hmcl/lwjgl3-natives/3.3.1-rc2/lwjgl3-natives-3.3.1-rc2-linux-mips64el.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl3-natives/3.3.1-rc2-linux-mips64el/lwjgl3-natives-3.3.1-rc2-linux-mips64el.jar",
                                              "sha1": "babec61846d8feb7a60cce1c9909281b1a3e0640",
                                              "size": 2464146
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-mips64el"
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "sha1": "a817bcf213db49f710603677457567c37d53e103",
                                            "size": 36601
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "sha1": "2623a6b8ae1dfcd880738656a9f0243d2e6840bd",
                                            "size": 88237
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "sha1": "831a5533a21a5f4f81bbc51bb13e9899319b5411",
                                            "size": 921563
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "sha1": "cbac1b8d30cb4795149c1ef540f912671a8616d0",
                                            "size": 128801
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "sha1": "b119297cf8ed01f247abe8685857f8e7fcf5980f",
                                            "size": 112380
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "sha1": "0ff1914111ef2e3e0110ef2dabc8d8cdaad82347",
                                            "size": 6767
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "sha1": "ae58664f88e18a9bb2c77b063833ca7aaec484cb",
                                            "size": 724243
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.2:natives": {
                                        "name": "org.glavo.hmcl:lwjgl3-natives:3.3.1-rc2",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-mips64el": {
                                              "path": "org/glavo/hmcl/lwjgl3-natives/3.3.1-rc2/lwjgl3-natives-3.3.1-rc2-linux-mips64el.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl3-natives/3.3.1-rc2-linux-mips64el/lwjgl3-natives-3.3.1-rc2-linux-mips64el.jar",
                                              "sha1": "babec61846d8feb7a60cce1c9909281b1a3e0640",
                                              "size": 2464146
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-mips64el"
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "sha1": "a817bcf213db49f710603677457567c37d53e103",
                                            "size": 36601
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl-openal:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "sha1": "2623a6b8ae1dfcd880738656a9f0243d2e6840bd",
                                            "size": 88237
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl-opengl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "sha1": "831a5533a21a5f4f81bbc51bb13e9899319b5411",
                                            "size": 921563
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl-glfw:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "sha1": "cbac1b8d30cb4795149c1ef540f912671a8616d0",
                                            "size": 128801
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl-stb:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "sha1": "b119297cf8ed01f247abe8685857f8e7fcf5980f",
                                            "size": 112380
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "sha1": "0ff1914111ef2e3e0110ef2dabc8d8cdaad82347",
                                            "size": 6767
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl:3.3.1:natives-linux": {
                                        "name": "org.glavo.hmcl:lwjgl3-natives:3.3.1-rc2",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-mips64el": {
                                              "path": "org/glavo/hmcl/lwjgl3-natives/3.3.1-rc2/lwjgl3-natives-3.3.1-rc2-linux-mips64el.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl3-natives/3.3.1-rc2-linux-mips64el/lwjgl3-natives-3.3.1-rc2-linux-mips64el.jar",
                                              "sha1": "babec61846d8feb7a60cce1c9909281b1a3e0640",
                                              "size": 2464146
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-mips64el"
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl-openal:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl-opengl:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl-glfw:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl-stb:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl-tinyfd:3.3.1:natives-linux": null,
                                      "net.java.jinput:jinput-platform:2.0.5:natives": null,
                                      "com.mojang:text2speech:1.10.3:natives": null,
                                      "com.mojang:text2speech:1.11.3:natives": null,
                                      "com.mojang:text2speech:1.12.4:natives": null,
                                      "com.mojang:text2speech:1.13.9:natives-linux": null
                                    },
                                    "linux-loongarch64": {
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.0:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3-rc2",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3-rc2/lwjgl2-natives-2.9.3-rc2-linux-loongarch64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-rc2-linux-loongarch64/lwjgl2-natives-2.9.3-rc2-linux-loongarch64.jar",
                                              "sha1": "f4d42d89b31d8c6c60e847042e350883c2cdaa25",
                                              "size": 623682
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64"
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.1:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3-rc2",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3-rc2/lwjgl2-natives-2.9.3-rc2-linux-loongarch64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-rc2-linux-loongarch64/lwjgl2-natives-2.9.3-rc2-linux-loongarch64.jar",
                                              "sha1": "f4d42d89b31d8c6c60e847042e350883c2cdaa25",
                                              "size": 623682
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64"
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.4-nightly-20150209:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3-rc2",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3-rc2/lwjgl2-natives-2.9.3-rc2-linux-loongarch64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-rc2-linux-loongarch64/lwjgl2-natives-2.9.3-rc2-linux-loongarch64.jar",
                                              "sha1": "f4d42d89b31d8c6c60e847042e350883c2cdaa25",
                                              "size": 623682
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64"
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "sha1": "ae58664f88e18a9bb2c77b063833ca7aaec484cb",
                                            "size": 724243
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.1.6:natives": {
                                        "name": "org.glavo.hmcl:lwjgl3-natives:3.3.1-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64": {
                                              "path": "org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1/lwjgl3-natives-3.3.1-rc1-linux-loongarch64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1-linux-loongarch64/lwjgl3-natives-3.3.1-rc1-linux-loongarch64.jar",
                                              "sha1": "2375ec8e8094a765ef61f3c4f2f832b1b8dfed4b",
                                              "size": 2651163
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64"
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "sha1": "a817bcf213db49f710603677457567c37d53e103",
                                            "size": 36601
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl-openal:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "sha1": "2623a6b8ae1dfcd880738656a9f0243d2e6840bd",
                                            "size": 88237
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl-opengl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "sha1": "831a5533a21a5f4f81bbc51bb13e9899319b5411",
                                            "size": 921563
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl-glfw:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "sha1": "cbac1b8d30cb4795149c1ef540f912671a8616d0",
                                            "size": 128801
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl-stb:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "sha1": "b119297cf8ed01f247abe8685857f8e7fcf5980f",
                                            "size": 112380
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "sha1": "0ff1914111ef2e3e0110ef2dabc8d8cdaad82347",
                                            "size": 6767
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "sha1": "ae58664f88e18a9bb2c77b063833ca7aaec484cb",
                                            "size": 724243
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.1:natives": {
                                        "name": "org.glavo.hmcl:lwjgl3-natives:3.3.1-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64": {
                                              "path": "org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1/lwjgl3-natives-3.3.1-rc1-linux-loongarch64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1-linux-loongarch64/lwjgl3-natives-3.3.1-rc1-linux-loongarch64.jar",
                                              "sha1": "2375ec8e8094a765ef61f3c4f2f832b1b8dfed4b",
                                              "size": 2651163
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64"
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "sha1": "a817bcf213db49f710603677457567c37d53e103",
                                            "size": 36601
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.1:natives": null,
                                      "org.lwjgl:lwjgl-openal:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "sha1": "2623a6b8ae1dfcd880738656a9f0243d2e6840bd",
                                            "size": 88237
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.1:natives": null,
                                      "org.lwjgl:lwjgl-opengl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "sha1": "831a5533a21a5f4f81bbc51bb13e9899319b5411",
                                            "size": 921563
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.1:natives": null,
                                      "org.lwjgl:lwjgl-glfw:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "sha1": "cbac1b8d30cb4795149c1ef540f912671a8616d0",
                                            "size": 128801
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.1:natives": null,
                                      "org.lwjgl:lwjgl-stb:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "sha1": "b119297cf8ed01f247abe8685857f8e7fcf5980f",
                                            "size": 112380
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.1:natives": null,
                                      "org.lwjgl:lwjgl-tinyfd:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "sha1": "0ff1914111ef2e3e0110ef2dabc8d8cdaad82347",
                                            "size": 6767
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.1:natives": null,
                                      "org.lwjgl:lwjgl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "sha1": "ae58664f88e18a9bb2c77b063833ca7aaec484cb",
                                            "size": 724243
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.2:natives": {
                                        "name": "org.glavo.hmcl:lwjgl3-natives:3.3.1-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64": {
                                              "path": "org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1/lwjgl3-natives-3.3.1-rc1-linux-loongarch64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1-linux-loongarch64/lwjgl3-natives-3.3.1-rc1-linux-loongarch64.jar",
                                              "sha1": "2375ec8e8094a765ef61f3c4f2f832b1b8dfed4b",
                                              "size": 2651163
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64"
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "sha1": "a817bcf213db49f710603677457567c37d53e103",
                                            "size": 36601
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl-openal:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "sha1": "2623a6b8ae1dfcd880738656a9f0243d2e6840bd",
                                            "size": 88237
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl-opengl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "sha1": "831a5533a21a5f4f81bbc51bb13e9899319b5411",
                                            "size": 921563
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl-glfw:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "sha1": "cbac1b8d30cb4795149c1ef540f912671a8616d0",
                                            "size": 128801
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl-stb:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "sha1": "b119297cf8ed01f247abe8685857f8e7fcf5980f",
                                            "size": 112380
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "sha1": "0ff1914111ef2e3e0110ef2dabc8d8cdaad82347",
                                            "size": 6767
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl:3.3.1:natives-linux": {
                                        "name": "org.glavo.hmcl:lwjgl3-natives:3.3.1-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64": {
                                              "path": "org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1/lwjgl3-natives-3.3.1-rc1-linux-loongarch64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1-linux-loongarch64/lwjgl3-natives-3.3.1-rc1-linux-loongarch64.jar",
                                              "sha1": "2375ec8e8094a765ef61f3c4f2f832b1b8dfed4b",
                                              "size": 2651163
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64"
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl-openal:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl-opengl:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl-glfw:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl-stb:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl-tinyfd:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl:3.3.2": {
                                        "name": "org.lwjgl:lwjgl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "sha1": "b86c3e4832426e8a6b466013b7cb34b40e9ce956",
                                            "size": 800127
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.2:natives-linux": {
                                        "name": "org.glavo.hmcl:lwjgl3-natives:3.3.4-rc2",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64": {
                                              "path": "org/glavo/hmcl/lwjgl3-natives/3.3.4-rc2/lwjgl3-natives-3.3.4-rc2-linux-loongarch64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl3-natives/3.3.4-rc2-linux-loongarch64/lwjgl3-natives-3.3.4-rc2-linux-loongarch64.jar",
                                              "sha1": "34a7f913c6750f2bede863f59c074cc4d540fb64",
                                              "size": 12234234
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64"
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "sha1": "e3f5dcb8e13f3a5ed3f740fd30a114cee2a80bc4",
                                            "size": 46430
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.2:natives-linux": null,
                                      "org.lwjgl:lwjgl-openal:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "sha1": "9b74d3ea380c83353d42af43ad9659e04dabe84a",
                                            "size": 113103
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.2:natives-linux": null,
                                      "org.lwjgl:lwjgl-opengl:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "sha1": "2852ac7d9f6fc71349f1ce28e2708ff1977f18af",
                                            "size": 931960
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.2:natives-linux": null,
                                      "org.lwjgl:lwjgl-glfw:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "sha1": "7e46ecdec85db8738053cfde1414352cd62dab74",
                                            "size": 147044
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.2:natives-linux": null,
                                      "org.lwjgl:lwjgl-stb:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "sha1": "5821735d5ef23f6da8542887344e57eb181b7cac",
                                            "size": 143112
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.2:natives-linux": null,
                                      "org.lwjgl:lwjgl-tinyfd:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "sha1": "2d73789ffd8962b38d9d599cc38b2383ce818c7a",
                                            "size": 15928
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.2:natives-linux": null,
                                      "org.lwjgl:lwjgl:3.3.3": {
                                        "name": "org.lwjgl:lwjgl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "sha1": "b86c3e4832426e8a6b466013b7cb34b40e9ce956",
                                            "size": 800127
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.3:natives-linux": {
                                        "name": "org.glavo.hmcl:lwjgl3-natives:3.3.4-rc2",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64": {
                                              "path": "org/glavo/hmcl/lwjgl3-natives/3.3.4-rc2/lwjgl3-natives-3.3.4-rc2-linux-loongarch64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl3-natives/3.3.4-rc2-linux-loongarch64/lwjgl3-natives-3.3.4-rc2-linux-loongarch64.jar",
                                              "sha1": "34a7f913c6750f2bede863f59c074cc4d540fb64",
                                              "size": 12234234
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64"
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "sha1": "e3f5dcb8e13f3a5ed3f740fd30a114cee2a80bc4",
                                            "size": 46430
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.3:natives-linux": null,
                                      "org.lwjgl:lwjgl-openal:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "sha1": "9b74d3ea380c83353d42af43ad9659e04dabe84a",
                                            "size": 113103
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.3:natives-linux": null,
                                      "org.lwjgl:lwjgl-opengl:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "sha1": "2852ac7d9f6fc71349f1ce28e2708ff1977f18af",
                                            "size": 931960
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.3:natives-linux": null,
                                      "org.lwjgl:lwjgl-glfw:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "sha1": "7e46ecdec85db8738053cfde1414352cd62dab74",
                                            "size": 147044
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.3:natives-linux": null,
                                      "org.lwjgl:lwjgl-stb:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "sha1": "5821735d5ef23f6da8542887344e57eb181b7cac",
                                            "size": 143112
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.3:natives-linux": null,
                                      "org.lwjgl:lwjgl-tinyfd:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "sha1": "2d73789ffd8962b38d9d599cc38b2383ce818c7a",
                                            "size": 15928
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.3:natives-linux": null,
                                      "org.lwjgl:lwjgl-freetype:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-freetype:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-freetype/3.3.4/lwjgl-freetype-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-freetype/3.3.4/lwjgl-freetype-3.3.4.jar",
                                            "sha1": "23f7bf165068ef2ca80ae1b79fd905af20498600",
                                            "size": 453489
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-freetype:3.3.3:natives-linux": null,
                                      "net.java.dev.jna:jna:5.8.0": {
                                        "name": "net.java.dev.jna:jna:5.13.0",
                                        "downloads": {
                                          "artifact": {
                                            "path": "net/java/dev/jna/jna/5.13.0/jna-5.13.0.jar",
                                            "url": "https://repo1.maven.org/maven2/net/java/dev/jna/jna/5.13.0/jna-5.13.0.jar",
                                            "sha1": "1200e7ebeedbe0d10062093f32925a912020e747",
                                            "size": 1879325
                                          }
                                        }
                                      },
                                      "net.java.dev.jna:jna-platform:5.8.0": {
                                        "name": "net.java.dev.jna:jna-platform:5.13.0",
                                        "downloads": {
                                          "artifact": {
                                            "path": "net/java/dev/jna/jna-platform/5.13.0/jna-platform-5.13.0.jar",
                                            "url": "https://repo1.maven.org/maven2/net/java/dev/jna/jna-platform/5.13.0/jna-platform-5.13.0.jar",
                                            "sha1": "88e9a306715e9379f3122415ef4ae759a352640d",
                                            "size": 1363209
                                          }
                                        }
                                      },
                                      "net.java.dev.jna:jna:5.10.0": {
                                        "name": "net.java.dev.jna:jna:5.13.0",
                                        "downloads": {
                                          "artifact": {
                                            "path": "net/java/dev/jna/jna/5.13.0/jna-5.13.0.jar",
                                            "url": "https://repo1.maven.org/maven2/net/java/dev/jna/jna/5.13.0/jna-5.13.0.jar",
                                            "sha1": "1200e7ebeedbe0d10062093f32925a912020e747",
                                            "size": 1879325
                                          }
                                        }
                                      },
                                      "net.java.dev.jna:jna-platform:5.10.0": {
                                        "name": "net.java.dev.jna:jna-platform:5.13.0",
                                        "downloads": {
                                          "artifact": {
                                            "path": "net/java/dev/jna/jna-platform/5.13.0/jna-platform-5.13.0.jar",
                                            "url": "https://repo1.maven.org/maven2/net/java/dev/jna/jna-platform/5.13.0/jna-platform-5.13.0.jar",
                                            "sha1": "88e9a306715e9379f3122415ef4ae759a352640d",
                                            "size": 1363209
                                          }
                                        }
                                      },
                                      "net.java.dev.jna:jna:5.12.1": {
                                        "name": "net.java.dev.jna:jna:5.13.0",
                                        "downloads": {
                                          "artifact": {
                                            "path": "net/java/dev/jna/jna/5.13.0/jna-5.13.0.jar",
                                            "url": "https://repo1.maven.org/maven2/net/java/dev/jna/jna/5.13.0/jna-5.13.0.jar",
                                            "sha1": "1200e7ebeedbe0d10062093f32925a912020e747",
                                            "size": 1879325
                                          }
                                        }
                                      },
                                      "net.java.dev.jna:jna-platform:5.12.1": {
                                        "name": "net.java.dev.jna:jna-platform:5.13.0",
                                        "downloads": {
                                          "artifact": {
                                            "path": "net/java/dev/jna/jna-platform/5.13.0/jna-platform-5.13.0.jar",
                                            "url": "https://repo1.maven.org/maven2/net/java/dev/jna/jna-platform/5.13.0/jna-platform-5.13.0.jar",
                                            "sha1": "88e9a306715e9379f3122415ef4ae759a352640d",
                                            "size": 1363209
                                          }
                                        }
                                      },
                                      "net.java.jinput:jinput-platform:2.0.5:natives": null,
                                      "com.mojang:text2speech:1.10.3:natives": null,
                                      "com.mojang:text2speech:1.11.3:natives": null,
                                      "com.mojang:text2speech:1.12.4:natives": null,
                                      "com.mojang:text2speech:1.13.9:natives-linux": null
                                    },
                                    "linux-loongarch64_ow": {
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.0:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1/lwjgl2-natives-2.9.3-rc1-linux-loongarch64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1-linux-loongarch64/lwjgl2-natives-2.9.3-rc1-linux-loongarch64.jar",
                                              "sha1": "135e7e557431be70fa590eb6feffebb078d34728",
                                              "size": 594335
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64"
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.1:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1/lwjgl2-natives-2.9.3-rc1-linux-loongarch64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1-linux-loongarch64/lwjgl2-natives-2.9.3-rc1-linux-loongarch64.jar",
                                              "sha1": "135e7e557431be70fa590eb6feffebb078d34728",
                                              "size": 594335
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64"
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.4-nightly-20150209:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1/lwjgl2-natives-2.9.3-rc1-linux-loongarch64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1-linux-loongarch64/lwjgl2-natives-2.9.3-rc1-linux-loongarch64.jar",
                                              "sha1": "135e7e557431be70fa590eb6feffebb078d34728",
                                              "size": 594335
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64"
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "sha1": "ae58664f88e18a9bb2c77b063833ca7aaec484cb",
                                            "size": 724243
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.1.6:natives": {
                                        "name": "org.glavo.hmcl:lwjgl3-natives:3.3.1-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64_ow": {
                                              "path": "org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1/lwjgl3-natives-3.3.1-rc1-linux-loongarch64_ow.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1-linux-loongarch64_ow/lwjgl3-natives-3.3.1-rc1-linux-loongarch64_ow.jar",
                                              "sha1": "4c7d6978dae411e5041f478d78cc329c4c75fc73",
                                              "size": 2311861
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64_ow"
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "sha1": "a817bcf213db49f710603677457567c37d53e103",
                                            "size": 36601
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl-openal:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "sha1": "2623a6b8ae1dfcd880738656a9f0243d2e6840bd",
                                            "size": 88237
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl-opengl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "sha1": "831a5533a21a5f4f81bbc51bb13e9899319b5411",
                                            "size": 921563
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl-glfw:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "sha1": "cbac1b8d30cb4795149c1ef540f912671a8616d0",
                                            "size": 128801
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl-stb:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "sha1": "b119297cf8ed01f247abe8685857f8e7fcf5980f",
                                            "size": 112380
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "sha1": "0ff1914111ef2e3e0110ef2dabc8d8cdaad82347",
                                            "size": 6767
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6:natives": null,
                                      "org.lwjgl:lwjgl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "sha1": "ae58664f88e18a9bb2c77b063833ca7aaec484cb",
                                            "size": 724243
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.1:natives": {
                                        "name": "org.glavo.hmcl:lwjgl3-natives:3.3.1-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64_ow": {
                                              "path": "org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1/lwjgl3-natives-3.3.1-rc1-linux-loongarch64_ow.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1-linux-loongarch64_ow/lwjgl3-natives-3.3.1-rc1-linux-loongarch64_ow.jar",
                                              "sha1": "4c7d6978dae411e5041f478d78cc329c4c75fc73",
                                              "size": 2311861
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64_ow"
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "sha1": "a817bcf213db49f710603677457567c37d53e103",
                                            "size": 36601
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.1:natives": null,
                                      "org.lwjgl:lwjgl-openal:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "sha1": "2623a6b8ae1dfcd880738656a9f0243d2e6840bd",
                                            "size": 88237
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.1:natives": null,
                                      "org.lwjgl:lwjgl-opengl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "sha1": "831a5533a21a5f4f81bbc51bb13e9899319b5411",
                                            "size": 921563
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.1:natives": null,
                                      "org.lwjgl:lwjgl-glfw:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "sha1": "cbac1b8d30cb4795149c1ef540f912671a8616d0",
                                            "size": 128801
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.1:natives": null,
                                      "org.lwjgl:lwjgl-stb:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "sha1": "b119297cf8ed01f247abe8685857f8e7fcf5980f",
                                            "size": 112380
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.1:natives": null,
                                      "org.lwjgl:lwjgl-tinyfd:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "sha1": "0ff1914111ef2e3e0110ef2dabc8d8cdaad82347",
                                            "size": 6767
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.1:natives": null,
                                      "org.lwjgl:lwjgl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "sha1": "ae58664f88e18a9bb2c77b063833ca7aaec484cb",
                                            "size": 724243
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.2:natives": {
                                        "name": "org.glavo.hmcl:lwjgl3-natives:3.3.1-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64_ow": {
                                              "path": "org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1/lwjgl3-natives-3.3.1-rc1-linux-loongarch64_ow.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1-linux-loongarch64_ow/lwjgl3-natives-3.3.1-rc1-linux-loongarch64_ow.jar",
                                              "sha1": "4c7d6978dae411e5041f478d78cc329c4c75fc73",
                                              "size": 2311861
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64_ow"
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "sha1": "a817bcf213db49f710603677457567c37d53e103",
                                            "size": 36601
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl-openal:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "sha1": "2623a6b8ae1dfcd880738656a9f0243d2e6840bd",
                                            "size": 88237
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl-opengl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "sha1": "831a5533a21a5f4f81bbc51bb13e9899319b5411",
                                            "size": 921563
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl-glfw:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1.jar",
                                            "sha1": "cbac1b8d30cb4795149c1ef540f912671a8616d0",
                                            "size": 128801
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl-stb:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "sha1": "b119297cf8ed01f247abe8685857f8e7fcf5980f",
                                            "size": 112380
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "sha1": "0ff1914111ef2e3e0110ef2dabc8d8cdaad82347",
                                            "size": 6767
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2:natives": null,
                                      "org.lwjgl:lwjgl:3.3.1:natives-linux": {
                                        "name": "org.glavo.hmcl:lwjgl3-natives:3.3.1-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "linux-loongarch64_ow": {
                                              "path": "org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1/lwjgl3-natives-3.3.1-rc1-linux-loongarch64_ow.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl3-natives/3.3.1-rc1-linux-loongarch64_ow/lwjgl3-natives-3.3.1-rc1-linux-loongarch64_ow.jar",
                                              "sha1": "4c7d6978dae411e5041f478d78cc329c4c75fc73",
                                              "size": 2311861
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "linux": "linux-loongarch64_ow"
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl-openal:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl-opengl:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl-glfw:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl-stb:3.3.1:natives-linux": null,
                                      "org.lwjgl:lwjgl-tinyfd:3.3.1:natives-linux": null,
                                      "net.java.dev.jna:jna:5.8.0": {
                                        "name": "org.glavo.hmcl:jna:5.13.0-rc1-linux-loongarch64_ow",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/glavo/hmcl/jna/5.13.0-rc1-linux-loongarch64_ow/jna-5.13.0-rc1-linux-loongarch64_ow.jar",
                                            "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/jna/5.13.0-rc1-linux-loongarch64_ow/jna-5.13.0-rc1-linux-loongarch64_ow.jar",
                                            "sha1": "42894c00949063f26752264288f2f2ab5179e21d",
                                            "size": 1886827
                                          }
                                        }
                                      },
                                      "net.java.dev.jna:jna-platform:5.8.0": {
                                        "name": "net.java.dev.jna:jna-platform:5.13.0",
                                        "downloads": {
                                          "artifact": {
                                            "path": "net/java/dev/jna/jna-platform/5.13.0/jna-platform-5.13.0.jar",
                                            "url": "https://repo1.maven.org/maven2/net/java/dev/jna/jna-platform/5.13.0/jna-platform-5.13.0.jar",
                                            "sha1": "88e9a306715e9379f3122415ef4ae759a352640d",
                                            "size": 1363209
                                          }
                                        }
                                      },
                                      "net.java.dev.jna:jna:5.10.0": {
                                        "name": "org.glavo.hmcl:jna:5.13.0-rc1-linux-loongarch64_ow",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/glavo/hmcl/jna/5.13.0-rc1-linux-loongarch64_ow/jna-5.13.0-rc1-linux-loongarch64_ow.jar",
                                            "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/jna/5.13.0-rc1-linux-loongarch64_ow/jna-5.13.0-rc1-linux-loongarch64_ow.jar",
                                            "sha1": "42894c00949063f26752264288f2f2ab5179e21d",
                                            "size": 1886827
                                          }
                                        }
                                      },
                                      "net.java.dev.jna:jna-platform:5.10.0": {
                                        "name": "net.java.dev.jna:jna-platform:5.13.0",
                                        "downloads": {
                                          "artifact": {
                                            "path": "net/java/dev/jna/jna-platform/5.13.0/jna-platform-5.13.0.jar",
                                            "url": "https://repo1.maven.org/maven2/net/java/dev/jna/jna-platform/5.13.0/jna-platform-5.13.0.jar",
                                            "sha1": "88e9a306715e9379f3122415ef4ae759a352640d",
                                            "size": 1363209
                                          }
                                        }
                                      },
                                      "net.java.dev.jna:jna:5.12.1": {
                                        "name": "org.glavo.hmcl:jna:5.13.0-rc1-linux-loongarch64_ow",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/glavo/hmcl/jna/5.13.0-rc1-linux-loongarch64_ow/jna-5.13.0-rc1-linux-loongarch64_ow.jar",
                                            "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/jna/5.13.0-rc1-linux-loongarch64_ow/jna-5.13.0-rc1-linux-loongarch64_ow.jar",
                                            "sha1": "42894c00949063f26752264288f2f2ab5179e21d",
                                            "size": 1886827
                                          }
                                        }
                                      },
                                      "net.java.dev.jna:jna-platform:5.12.1": {
                                        "name": "net.java.dev.jna:jna-platform:5.13.0",
                                        "downloads": {
                                          "artifact": {
                                            "path": "net/java/dev/jna/jna-platform/5.13.0/jna-platform-5.13.0.jar",
                                            "url": "https://repo1.maven.org/maven2/net/java/dev/jna/jna-platform/5.13.0/jna-platform-5.13.0.jar",
                                            "sha1": "88e9a306715e9379f3122415ef4ae759a352640d",
                                            "size": 1363209
                                          }
                                        }
                                      },
                                      "net.java.jinput:jinput-platform:2.0.5:natives": null,
                                      "com.mojang:text2speech:1.10.3:natives": null,
                                      "com.mojang:text2speech:1.11.3:natives": null,
                                      "com.mojang:text2speech:1.12.4:natives": null,
                                      "com.mojang:text2speech:1.13.9:natives-linux": null
                                    },
                                    "linux-riscv64": {
                                      "org.lwjgl:lwjgl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "sha1": "b86c3e4832426e8a6b466013b7cb34b40e9ce956",
                                            "size": 800127
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "3ce36a5c5e6feb61bad2ea1426352482e04c6db1",
                                            "size": 80164
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "sha1": "e3f5dcb8e13f3a5ed3f740fd30a114cee2a80bc4",
                                            "size": 46430
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "6c5d38aad1dbd1c4945bcbe86640e616ceb9588f",
                                            "size": 197209
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "sha1": "9b74d3ea380c83353d42af43ad9659e04dabe84a",
                                            "size": 113103
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "74c5ddf47ad6bee41348bbb0735008694b5315af",
                                            "size": 516661
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "sha1": "2852ac7d9f6fc71349f1ce28e2708ff1977f18af",
                                            "size": 931960
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "6ea07b47dd91af8f3ee4a24ddb3cbf086d157a4e",
                                            "size": 57864
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "sha1": "7e46ecdec85db8738053cfde1414352cd62dab74",
                                            "size": 147044
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "9582481036b6fb762c3f791e2ed26128152a1cec",
                                            "size": 117084
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "sha1": "5821735d5ef23f6da8542887344e57eb181b7cac",
                                            "size": 143112
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "502804ee61eb7adb30bbb5e4459899f9a0cb23cf",
                                            "size": 215885
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "sha1": "2d73789ffd8962b38d9d599cc38b2383ce818c7a",
                                            "size": 15928
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "8bec171d3fa4ec3cfc20b4ddd675cb08935bd5f8",
                                            "size": 46550
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "sha1": "b86c3e4832426e8a6b466013b7cb34b40e9ce956",
                                            "size": 800127
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "3ce36a5c5e6feb61bad2ea1426352482e04c6db1",
                                            "size": 80164
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "sha1": "e3f5dcb8e13f3a5ed3f740fd30a114cee2a80bc4",
                                            "size": 46430
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "6c5d38aad1dbd1c4945bcbe86640e616ceb9588f",
                                            "size": 197209
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "sha1": "9b74d3ea380c83353d42af43ad9659e04dabe84a",
                                            "size": 113103
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "74c5ddf47ad6bee41348bbb0735008694b5315af",
                                            "size": 516661
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "sha1": "2852ac7d9f6fc71349f1ce28e2708ff1977f18af",
                                            "size": 931960
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "6ea07b47dd91af8f3ee4a24ddb3cbf086d157a4e",
                                            "size": 57864
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "sha1": "7e46ecdec85db8738053cfde1414352cd62dab74",
                                            "size": 147044
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "9582481036b6fb762c3f791e2ed26128152a1cec",
                                            "size": 117084
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "sha1": "5821735d5ef23f6da8542887344e57eb181b7cac",
                                            "size": 143112
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "502804ee61eb7adb30bbb5e4459899f9a0cb23cf",
                                            "size": 215885
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "sha1": "2d73789ffd8962b38d9d599cc38b2383ce818c7a",
                                            "size": 15928
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "8bec171d3fa4ec3cfc20b4ddd675cb08935bd5f8",
                                            "size": 46550
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "sha1": "b86c3e4832426e8a6b466013b7cb34b40e9ce956",
                                            "size": 800127
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "3ce36a5c5e6feb61bad2ea1426352482e04c6db1",
                                            "size": 80164
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "sha1": "e3f5dcb8e13f3a5ed3f740fd30a114cee2a80bc4",
                                            "size": 46430
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "6c5d38aad1dbd1c4945bcbe86640e616ceb9588f",
                                            "size": 197209
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "sha1": "9b74d3ea380c83353d42af43ad9659e04dabe84a",
                                            "size": 113103
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "74c5ddf47ad6bee41348bbb0735008694b5315af",
                                            "size": 516661
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "sha1": "2852ac7d9f6fc71349f1ce28e2708ff1977f18af",
                                            "size": 931960
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "6ea07b47dd91af8f3ee4a24ddb3cbf086d157a4e",
                                            "size": 57864
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "sha1": "7e46ecdec85db8738053cfde1414352cd62dab74",
                                            "size": 147044
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "9582481036b6fb762c3f791e2ed26128152a1cec",
                                            "size": 117084
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "sha1": "5821735d5ef23f6da8542887344e57eb181b7cac",
                                            "size": 143112
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "502804ee61eb7adb30bbb5e4459899f9a0cb23cf",
                                            "size": 215885
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "sha1": "2d73789ffd8962b38d9d599cc38b2383ce818c7a",
                                            "size": 15928
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "8bec171d3fa4ec3cfc20b4ddd675cb08935bd5f8",
                                            "size": 46550
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.1": {
                                        "name": "org.lwjgl:lwjgl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "sha1": "b86c3e4832426e8a6b466013b7cb34b40e9ce956",
                                            "size": 800127
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "3ce36a5c5e6feb61bad2ea1426352482e04c6db1",
                                            "size": 80164
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "sha1": "e3f5dcb8e13f3a5ed3f740fd30a114cee2a80bc4",
                                            "size": 46430
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "6c5d38aad1dbd1c4945bcbe86640e616ceb9588f",
                                            "size": 197209
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "sha1": "9b74d3ea380c83353d42af43ad9659e04dabe84a",
                                            "size": 113103
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "74c5ddf47ad6bee41348bbb0735008694b5315af",
                                            "size": 516661
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "sha1": "2852ac7d9f6fc71349f1ce28e2708ff1977f18af",
                                            "size": 931960
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "6ea07b47dd91af8f3ee4a24ddb3cbf086d157a4e",
                                            "size": 57864
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "sha1": "7e46ecdec85db8738053cfde1414352cd62dab74",
                                            "size": 147044
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "9582481036b6fb762c3f791e2ed26128152a1cec",
                                            "size": 117084
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "sha1": "5821735d5ef23f6da8542887344e57eb181b7cac",
                                            "size": 143112
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "502804ee61eb7adb30bbb5e4459899f9a0cb23cf",
                                            "size": 215885
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "sha1": "2d73789ffd8962b38d9d599cc38b2383ce818c7a",
                                            "size": 15928
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "8bec171d3fa4ec3cfc20b4ddd675cb08935bd5f8",
                                            "size": 46550
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.2": {
                                        "name": "org.lwjgl:lwjgl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "sha1": "b86c3e4832426e8a6b466013b7cb34b40e9ce956",
                                            "size": 800127
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "3ce36a5c5e6feb61bad2ea1426352482e04c6db1",
                                            "size": 80164
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "sha1": "e3f5dcb8e13f3a5ed3f740fd30a114cee2a80bc4",
                                            "size": 46430
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "6c5d38aad1dbd1c4945bcbe86640e616ceb9588f",
                                            "size": 197209
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "sha1": "9b74d3ea380c83353d42af43ad9659e04dabe84a",
                                            "size": 113103
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "74c5ddf47ad6bee41348bbb0735008694b5315af",
                                            "size": 516661
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "sha1": "2852ac7d9f6fc71349f1ce28e2708ff1977f18af",
                                            "size": 931960
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "6ea07b47dd91af8f3ee4a24ddb3cbf086d157a4e",
                                            "size": 57864
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "sha1": "7e46ecdec85db8738053cfde1414352cd62dab74",
                                            "size": 147044
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "9582481036b6fb762c3f791e2ed26128152a1cec",
                                            "size": 117084
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "sha1": "5821735d5ef23f6da8542887344e57eb181b7cac",
                                            "size": 143112
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "502804ee61eb7adb30bbb5e4459899f9a0cb23cf",
                                            "size": 215885
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "sha1": "2d73789ffd8962b38d9d599cc38b2383ce818c7a",
                                            "size": 15928
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "8bec171d3fa4ec3cfc20b4ddd675cb08935bd5f8",
                                            "size": 46550
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.3": {
                                        "name": "org.lwjgl:lwjgl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "sha1": "b86c3e4832426e8a6b466013b7cb34b40e9ce956",
                                            "size": 800127
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "3ce36a5c5e6feb61bad2ea1426352482e04c6db1",
                                            "size": 80164
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "sha1": "e3f5dcb8e13f3a5ed3f740fd30a114cee2a80bc4",
                                            "size": 46430
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "6c5d38aad1dbd1c4945bcbe86640e616ceb9588f",
                                            "size": 197209
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "sha1": "9b74d3ea380c83353d42af43ad9659e04dabe84a",
                                            "size": 113103
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "74c5ddf47ad6bee41348bbb0735008694b5315af",
                                            "size": 516661
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "sha1": "2852ac7d9f6fc71349f1ce28e2708ff1977f18af",
                                            "size": 931960
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "6ea07b47dd91af8f3ee4a24ddb3cbf086d157a4e",
                                            "size": 57864
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "sha1": "7e46ecdec85db8738053cfde1414352cd62dab74",
                                            "size": 147044
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "9582481036b6fb762c3f791e2ed26128152a1cec",
                                            "size": 117084
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "sha1": "5821735d5ef23f6da8542887344e57eb181b7cac",
                                            "size": 143112
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "502804ee61eb7adb30bbb5e4459899f9a0cb23cf",
                                            "size": 215885
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "sha1": "2d73789ffd8962b38d9d599cc38b2383ce818c7a",
                                            "size": 15928
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "8bec171d3fa4ec3cfc20b4ddd675cb08935bd5f8",
                                            "size": 46550
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-freetype:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-freetype:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-freetype/3.3.4/lwjgl-freetype-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-freetype/3.3.4/lwjgl-freetype-3.3.4.jar",
                                            "sha1": "23f7bf165068ef2ca80ae1b79fd905af20498600",
                                            "size": 453489
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-freetype:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-freetype:3.3.4:natives-linux-riscv64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-freetype/3.3.4/lwjgl-freetype-3.3.4-natives-linux-riscv64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-freetype/3.3.4/lwjgl-freetype-3.3.4-natives-linux-riscv64.jar",
                                            "sha1": "2cb82939dc283686f9febf5349b66e773f515c59",
                                            "size": 1194584
                                          }
                                        }
                                      },
                                      "net.java.jinput:jinput-platform:2.0.5:natives": null,
                                      "com.mojang:text2speech:1.10.3:natives": null,
                                      "com.mojang:text2speech:1.11.3:natives": null,
                                      "com.mojang:text2speech:1.12.4:natives": null,
                                      "com.mojang:text2speech:1.13.9:natives-linux": null
                                    },
                                    "windows-x86_64": {
                                      "mesa-loader": {
                                        "name": "org.glavo:mesa-loader-windows:0.3.0:x64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/glavo/mesa-loader-windows/0.3.0/mesa-loader-windows-0.3.0-x64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/glavo/mesa-loader-windows/0.3.0/mesa-loader-windows-0.3.0-x64.jar",
                                            "sha1": "629fca32417d6ec489cef8b2cbd0827131ec6801",
                                            "size": 27174940
                                          }
                                        }
                                      }
                                    },
                                    "windows-x86": {
                                      "mesa-loader": {
                                        "name": "org.glavo:mesa-loader-windows:0.3.0:x86",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/glavo/mesa-loader-windows/0.3.0/mesa-loader-windows-0.3.0-x86.jar",
                                            "url": "https://repo1.maven.org/maven2/org/glavo/mesa-loader-windows/0.3.0/mesa-loader-windows-0.3.0-x86.jar",
                                            "sha1": "d25e0cdf5c5eb182acc9b93f700e0e6d8de36283",
                                            "size": 22528549
                                          }
                                        }
                                      }
                                    },
                                    "windows-arm64": {
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.0:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "windows-arm64": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1/lwjgl2-natives-2.9.3-rc1-windows-arm64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1-windows-arm64/lwjgl2-natives-2.9.3-rc1-windows-arm64.jar",
                                              "sha1": "e0948a3692856d47854f3cd5a698d5c0233606d7",
                                              "size": 617106
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "windows": "windows-arm64"
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.1:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "windows-arm64": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1/lwjgl2-natives-2.9.3-rc1-windows-arm64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1-windows-arm64/lwjgl2-natives-2.9.3-rc1-windows-arm64.jar",
                                              "sha1": "e0948a3692856d47854f3cd5a698d5c0233606d7",
                                              "size": 617106
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "windows": "windows-arm64"
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.4-nightly-20150209:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "windows-arm64": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1/lwjgl2-natives-2.9.3-rc1-windows-arm64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1-windows-arm64/lwjgl2-natives-2.9.3-rc1-windows-arm64.jar",
                                              "sha1": "e0948a3692856d47854f3cd5a698d5c0233606d7",
                                              "size": 617106
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "windows": "windows-arm64"
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2.jar",
                                            "sha1": "4421d94af68e35dcaa31737a6fc59136a1e61b94",
                                            "size": 786196
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl:3.3.2:natives-windows-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2-natives-windows-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2-natives-windows-arm64.jar",
                                            "sha1": "d900e4678449ba97ff46fa64b22e0376bf8cd00e",
                                            "size": 133200
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2.jar",
                                            "sha1": "877e17e39ebcd58a9c956dc3b5b777813de0873a",
                                            "size": 43233
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.2:natives-windows-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2-natives-windows-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2-natives-windows-arm64.jar",
                                            "sha1": "598790de603c286dbc4068b27829eacc37592786",
                                            "size": 152780
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2.jar",
                                            "sha1": "ae5357ed6d934546d3533993ea84c0cfb75eed95",
                                            "size": 108230
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.2:natives-windows-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2-natives-windows-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2-natives-windows-arm64.jar",
                                            "sha1": "545ddec7959007a78b6662d616e00dacf00e1c29",
                                            "size": 627059
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2.jar",
                                            "sha1": "ee8e95be0b438602038bc1f02dc5e3d011b1b216",
                                            "size": 928871
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.2:natives-windows-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2-natives-windows-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2-natives-windows-arm64.jar",
                                            "sha1": "21df035bf03dbf5001f92291b24dc951da513481",
                                            "size": 83132
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2.jar",
                                            "sha1": "757920418805fb90bfebb3d46b1d9e7669fca2eb",
                                            "size": 135828
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.2:natives-windows-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2-natives-windows-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2-natives-windows-arm64.jar",
                                            "sha1": "e79c4857a887bd79ba78bdf2d422a7d333028a2d",
                                            "size": 141892
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2.jar",
                                            "sha1": "a2550795014d622b686e9caac50b14baa87d2c70",
                                            "size": 118874
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.2:natives-windows-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2-natives-windows-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2-natives-windows-arm64.jar",
                                            "sha1": "c29df97c3cca97dc00d34e171936153764c9f78b",
                                            "size": 218460
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2.jar",
                                            "sha1": "9f65c248dd77934105274fcf8351abb75b34327c",
                                            "size": 13404
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.2:natives-windows-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2-natives-windows-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2-natives-windows-arm64.jar",
                                            "sha1": "500f5daa3b731ca282d4b90aeafda94c528d3e27",
                                            "size": 110758
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2.jar",
                                            "sha1": "4421d94af68e35dcaa31737a6fc59136a1e61b94",
                                            "size": 786196
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl:3.3.2:natives-windows-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2-natives-windows-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl/3.3.2/lwjgl-3.3.2-natives-windows-arm64.jar",
                                            "sha1": "d900e4678449ba97ff46fa64b22e0376bf8cd00e",
                                            "size": 133200
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2.jar",
                                            "sha1": "877e17e39ebcd58a9c956dc3b5b777813de0873a",
                                            "size": 43233
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.2:natives-windows-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2-natives-windows-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-jemalloc/3.3.2/lwjgl-jemalloc-3.3.2-natives-windows-arm64.jar",
                                            "sha1": "598790de603c286dbc4068b27829eacc37592786",
                                            "size": 152780
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2.jar",
                                            "sha1": "ae5357ed6d934546d3533993ea84c0cfb75eed95",
                                            "size": 108230
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.2:natives-windows-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2-natives-windows-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-openal/3.3.2/lwjgl-openal-3.3.2-natives-windows-arm64.jar",
                                            "sha1": "545ddec7959007a78b6662d616e00dacf00e1c29",
                                            "size": 627059
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2.jar",
                                            "sha1": "ee8e95be0b438602038bc1f02dc5e3d011b1b216",
                                            "size": 928871
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.2:natives-windows-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2-natives-windows-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-opengl/3.3.2/lwjgl-opengl-3.3.2-natives-windows-arm64.jar",
                                            "sha1": "21df035bf03dbf5001f92291b24dc951da513481",
                                            "size": 83132
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2.jar",
                                            "sha1": "757920418805fb90bfebb3d46b1d9e7669fca2eb",
                                            "size": 135828
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.2:natives-windows-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2-natives-windows-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-glfw/3.3.2/lwjgl-glfw-3.3.2-natives-windows-arm64.jar",
                                            "sha1": "e79c4857a887bd79ba78bdf2d422a7d333028a2d",
                                            "size": 141892
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2.jar",
                                            "sha1": "a2550795014d622b686e9caac50b14baa87d2c70",
                                            "size": 118874
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.2:natives-windows-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2-natives-windows-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-stb/3.3.2/lwjgl-stb-3.3.2-natives-windows-arm64.jar",
                                            "sha1": "c29df97c3cca97dc00d34e171936153764c9f78b",
                                            "size": 218460
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.2",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2.jar",
                                            "sha1": "9f65c248dd77934105274fcf8351abb75b34327c",
                                            "size": 13404
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.2:natives-windows-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2-natives-windows-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-tinyfd/3.3.2/lwjgl-tinyfd-3.3.2-natives-windows-arm64.jar",
                                            "sha1": "500f5daa3b731ca282d4b90aeafda94c528d3e27",
                                            "size": 110758
                                          }
                                        }
                                      },
                                      "net.java.jinput:jinput-platform:2.0.5:natives": null,
                                      "com.mojang:text2speech:1.10.3:natives": null,
                                      "com.mojang:text2speech:1.11.3:natives": null,
                                      "com.mojang:text2speech:1.12.4:natives": null,
                                      "com.mojang:text2speech:1.13.9:natives-windows": null,
                                      "mesa-loader": {
                                        "name": "org.glavo:mesa-loader-windows:0.3.0:arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/glavo/mesa-loader-windows/0.3.0/mesa-loader-windows-0.3.0-arm64.jar",
                                            "url": "https://repo1.maven.org/maven2/org/glavo/mesa-loader-windows/0.3.0/mesa-loader-windows-0.3.0-arm64.jar",
                                            "sha1": "1986490c6fbe950e64018c2fb62c8ecf77a247ed",
                                            "size": 24082103
                                          }
                                        }
                                      }
                                    },
                                    "osx-arm64": {
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.1-nightly-20130708-debug3:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "osx-arm64": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1/lwjgl2-natives-2.9.3-rc1-osx-arm64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1-osx-arm64/lwjgl2-natives-2.9.3-rc1-osx-arm64.jar",
                                              "sha1": "042ef2024a9a4054952c496c9ebcdb83345dabe0",
                                              "size": 500107
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "osx": "osx-arm64"
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.1:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "osx-arm64": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1/lwjgl2-natives-2.9.3-rc1-osx-arm64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1-osx-arm64/lwjgl2-natives-2.9.3-rc1-osx-arm64.jar",
                                              "sha1": "042ef2024a9a4054952c496c9ebcdb83345dabe0",
                                              "size": 500107
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "osx": "osx-arm64"
                                        }
                                      },
                                      "org.lwjgl.lwjgl:lwjgl-platform:2.9.2-nightly-20140822:natives": {
                                        "name": "org.glavo.hmcl:lwjgl2-natives:2.9.3-rc1",
                                        "downloads": {
                                          "classifiers": {
                                            "osx-arm64": {
                                              "path": "org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1/lwjgl2-natives-2.9.3-rc1-osx-arm64.jar",
                                              "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/lwjgl2-natives/2.9.3-rc1-osx-arm64/lwjgl2-natives-2.9.3-rc1-osx-arm64.jar",
                                              "sha1": "042ef2024a9a4054952c496c9ebcdb83345dabe0",
                                              "size": 500107
                                            }
                                          }
                                        },
                                        "extract": {
                                          "exclude": [
                                            "META-INF/"
                                          ]
                                        },
                                        "natives": {
                                          "osx": "osx-arm64"
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "sha1": "ae58664f88e18a9bb2c77b063833ca7aaec484cb",
                                            "size": 724243
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl:3.3.1:natives-macos-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1-natives-macos-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1-natives-macos-arm64.jar",
                                            "sha1": "71d0d5e469c9c95351eb949064497e3391616ac9",
                                            "size": 42693
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "sha1": "a817bcf213db49f710603677457567c37d53e103",
                                            "size": 36601
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.1:natives-macos-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1-natives-macos-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1-natives-macos-arm64.jar",
                                            "sha1": "e577b87d8ad2ade361aaea2fcf226c660b15dee8",
                                            "size": 103475
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "sha1": "2623a6b8ae1dfcd880738656a9f0243d2e6840bd",
                                            "size": 88237
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.1:natives-macos-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1-natives-macos-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1-natives-macos-arm64.jar",
                                            "sha1": "23d55e7490b57495320f6c9e1936d78fd72c4ef8",
                                            "size": 346125
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "sha1": "831a5533a21a5f4f81bbc51bb13e9899319b5411",
                                            "size": 921563
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.1:natives-macos-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1-natives-macos-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1-natives-macos-arm64.jar",
                                            "sha1": "eafe34b871d966292e8db0f1f3d6b8b110d4e91d",
                                            "size": 41665
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.1.6": {
                                        "name": "org.glavo.hmcl.mmachina:lwjgl-glfw:3.3.1-mmachina.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/glavo/hmcl/mmachina/lwjgl-glfw/3.3.1-mmachina.1/lwjgl-glfw-3.3.1-mmachina.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/mmachina/lwjgl-glfw/3.3.1-mmachina.1/lwjgl-glfw-3.3.1-mmachina.1.jar",
                                            "sha1": "e9a101bca4fa30d26b21b526ff28e7c2d8927f1b",
                                            "size": 130128
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.1:natives-macos-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1-natives-macos-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1-natives-macos-arm64.jar",
                                            "sha1": "cac0d3f712a3da7641fa174735a5f315de7ffe0a",
                                            "size": 129077
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "sha1": "b119297cf8ed01f247abe8685857f8e7fcf5980f",
                                            "size": 112380
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.1:natives-macos-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1-natives-macos-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1-natives-macos-arm64.jar",
                                            "sha1": "fcf073ed911752abdca5f0b00a53cfdf17ff8e8b",
                                            "size": 178408
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "sha1": "0ff1914111ef2e3e0110ef2dabc8d8cdaad82347",
                                            "size": 6767
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.1:natives-macos-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1-natives-macos-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1-natives-macos-arm64.jar",
                                            "sha1": "972ecc17bad3571e81162153077b4d47b7b9eaa9",
                                            "size": 41380
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1.jar",
                                            "sha1": "ae58664f88e18a9bb2c77b063833ca7aaec484cb",
                                            "size": 724243
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl:3.3.1:natives-macos-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1-natives-macos-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl/3.3.1/lwjgl-3.3.1-natives-macos-arm64.jar",
                                            "sha1": "71d0d5e469c9c95351eb949064497e3391616ac9",
                                            "size": 42693
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1.jar",
                                            "sha1": "a817bcf213db49f710603677457567c37d53e103",
                                            "size": 36601
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.1:natives-macos-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1-natives-macos-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-jemalloc/3.3.1/lwjgl-jemalloc-3.3.1-natives-macos-arm64.jar",
                                            "sha1": "e577b87d8ad2ade361aaea2fcf226c660b15dee8",
                                            "size": 103475
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1.jar",
                                            "sha1": "2623a6b8ae1dfcd880738656a9f0243d2e6840bd",
                                            "size": 88237
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.1:natives-macos-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1-natives-macos-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-openal/3.3.1/lwjgl-openal-3.3.1-natives-macos-arm64.jar",
                                            "sha1": "23d55e7490b57495320f6c9e1936d78fd72c4ef8",
                                            "size": 346125
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1.jar",
                                            "sha1": "831a5533a21a5f4f81bbc51bb13e9899319b5411",
                                            "size": 921563
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.1:natives-macos-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1-natives-macos-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-opengl/3.3.1/lwjgl-opengl-3.3.1-natives-macos-arm64.jar",
                                            "sha1": "eafe34b871d966292e8db0f1f3d6b8b110d4e91d",
                                            "size": 41665
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.1": {
                                        "name": "org.glavo.hmcl.mmachina:lwjgl-glfw:3.3.1-mmachina.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/glavo/hmcl/mmachina/lwjgl-glfw/3.3.1-mmachina.1/lwjgl-glfw-3.3.1-mmachina.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/mmachina/lwjgl-glfw/3.3.1-mmachina.1/lwjgl-glfw-3.3.1-mmachina.1.jar",
                                            "sha1": "e9a101bca4fa30d26b21b526ff28e7c2d8927f1b",
                                            "size": 130128
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.1:natives-macos-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1-natives-macos-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-glfw/3.3.1/lwjgl-glfw-3.3.1-natives-macos-arm64.jar",
                                            "sha1": "cac0d3f712a3da7641fa174735a5f315de7ffe0a",
                                            "size": 129077
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1.jar",
                                            "sha1": "b119297cf8ed01f247abe8685857f8e7fcf5980f",
                                            "size": 112380
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.1:natives-macos-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1-natives-macos-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-stb/3.3.1/lwjgl-stb-3.3.1-natives-macos-arm64.jar",
                                            "sha1": "fcf073ed911752abdca5f0b00a53cfdf17ff8e8b",
                                            "size": 178408
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1.jar",
                                            "sha1": "0ff1914111ef2e3e0110ef2dabc8d8cdaad82347",
                                            "size": 6767
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.1:natives-macos-arm64",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1-natives-macos-arm64.jar",
                                            "url": "https://libraries.minecraft.net/org/lwjgl/lwjgl-tinyfd/3.3.1/lwjgl-tinyfd-3.3.1-natives-macos-arm64.jar",
                                            "sha1": "972ecc17bad3571e81162153077b4d47b7b9eaa9",
                                            "size": 41380
                                          }
                                        }
                                      },
                                      "ca.weblite:java-objc-bridge:1.0.0": {
                                        "name": "org.glavo.hmcl.mmachina:java-objc-bridge:1.1.0-mmachina.1",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/glavo/hmcl/mmachina/java-objc-bridge/1.1.0-mmachina.1/java-objc-bridge-1.1.0-mmachina.1.jar",
                                            "url": "https://repo1.maven.org/maven2/org/glavo/hmcl/mmachina/java-objc-bridge/1.1.0-mmachina.1/java-objc-bridge-1.1.0-mmachina.1.jar",
                                            "sha1": "369a83621e3c65496348491e533cb97fe5f2f37d",
                                            "size": 91947
                                          }
                                        }
                                      },
                                      "ca.weblite:java-objc-bridge:1.0.0:natives": null,
                                      "com.mojang:text2speech:1.10.3": {
                                        "name": "com.mojang:text2speech:1.11.3",
                                        "downloads": {
                                          "artifact": {
                                            "path": "com/mojang/text2speech/1.11.3/text2speech-1.11.3.jar",
                                            "url": "https://libraries.minecraft.net/com/mojang/text2speech/1.11.3/text2speech-1.11.3.jar",
                                            "sha1": "f378f889797edd7df8d32272c06ca80a1b6b0f58",
                                            "size": 13164
                                          }
                                        }
                                      },
                                      "net.java.jinput:jinput-platform:2.0.5:natives": null,
                                      "com.mojang:text2speech:1.10.3:natives": null,
                                      "com.mojang:text2speech:1.11.3:natives": null,
                                      "com.mojang:text2speech:1.12.4:natives": null
                                    },
                                    "freebsd-x86_64": {
                                      "org.lwjgl:lwjgl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "sha1": "b86c3e4832426e8a6b466013b7cb34b40e9ce956",
                                            "size": 800127
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-freebsd.jar",
                                            "sha1": "610d14530e637564d97d74af7cb98a737e70b77b",
                                            "size": 96209
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "sha1": "e3f5dcb8e13f3a5ed3f740fd30a114cee2a80bc4",
                                            "size": 46430
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-freebsd.jar",
                                            "sha1": "5ee27f3bad4715067cef0630682da4bb5a1b88ac",
                                            "size": 157297
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "sha1": "9b74d3ea380c83353d42af43ad9659e04dabe84a",
                                            "size": 113103
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-freebsd.jar",
                                            "sha1": "3863f8268f5515c27f1364257f8a018f0c6afa79",
                                            "size": 597486
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "sha1": "2852ac7d9f6fc71349f1ce28e2708ff1977f18af",
                                            "size": 931960
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-freebsd.jar",
                                            "sha1": "579071d2a3714f5662522f7d3edf58e941580587",
                                            "size": 81028
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "sha1": "7e46ecdec85db8738053cfde1414352cd62dab74",
                                            "size": 147044
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-freebsd.jar",
                                            "sha1": "f67b9b6c29451d8fea66db17aaba2f65e908c7e9",
                                            "size": 104415
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "sha1": "5821735d5ef23f6da8542887344e57eb181b7cac",
                                            "size": 143112
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-freebsd.jar",
                                            "sha1": "f5551338a1e2035ff747053f0e985dc93db1235c",
                                            "size": 226093
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "sha1": "2d73789ffd8962b38d9d599cc38b2383ce818c7a",
                                            "size": 15928
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.1.6:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-freebsd.jar",
                                            "sha1": "acd5e1b9b9b99ce4d21867058ee468ee45a859e5",
                                            "size": 40104
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "sha1": "b86c3e4832426e8a6b466013b7cb34b40e9ce956",
                                            "size": 800127
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-freebsd.jar",
                                            "sha1": "610d14530e637564d97d74af7cb98a737e70b77b",
                                            "size": 96209
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "sha1": "e3f5dcb8e13f3a5ed3f740fd30a114cee2a80bc4",
                                            "size": 46430
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-freebsd.jar",
                                            "sha1": "5ee27f3bad4715067cef0630682da4bb5a1b88ac",
                                            "size": 157297
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "sha1": "9b74d3ea380c83353d42af43ad9659e04dabe84a",
                                            "size": 113103
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-freebsd.jar",
                                            "sha1": "3863f8268f5515c27f1364257f8a018f0c6afa79",
                                            "size": 597486
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "sha1": "2852ac7d9f6fc71349f1ce28e2708ff1977f18af",
                                            "size": 931960
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-freebsd.jar",
                                            "sha1": "579071d2a3714f5662522f7d3edf58e941580587",
                                            "size": 81028
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "sha1": "7e46ecdec85db8738053cfde1414352cd62dab74",
                                            "size": 147044
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-freebsd.jar",
                                            "sha1": "f67b9b6c29451d8fea66db17aaba2f65e908c7e9",
                                            "size": 104415
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "sha1": "5821735d5ef23f6da8542887344e57eb181b7cac",
                                            "size": 143112
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-freebsd.jar",
                                            "sha1": "f5551338a1e2035ff747053f0e985dc93db1235c",
                                            "size": 226093
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.1": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "sha1": "2d73789ffd8962b38d9d599cc38b2383ce818c7a",
                                            "size": 15928
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.1:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-freebsd.jar",
                                            "sha1": "acd5e1b9b9b99ce4d21867058ee468ee45a859e5",
                                            "size": 40104
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "sha1": "b86c3e4832426e8a6b466013b7cb34b40e9ce956",
                                            "size": 800127
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-freebsd.jar",
                                            "sha1": "610d14530e637564d97d74af7cb98a737e70b77b",
                                            "size": 96209
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "sha1": "e3f5dcb8e13f3a5ed3f740fd30a114cee2a80bc4",
                                            "size": 46430
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-freebsd.jar",
                                            "sha1": "5ee27f3bad4715067cef0630682da4bb5a1b88ac",
                                            "size": 157297
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "sha1": "9b74d3ea380c83353d42af43ad9659e04dabe84a",
                                            "size": 113103
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-freebsd.jar",
                                            "sha1": "3863f8268f5515c27f1364257f8a018f0c6afa79",
                                            "size": 597486
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "sha1": "2852ac7d9f6fc71349f1ce28e2708ff1977f18af",
                                            "size": 931960
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-freebsd.jar",
                                            "sha1": "579071d2a3714f5662522f7d3edf58e941580587",
                                            "size": 81028
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "sha1": "7e46ecdec85db8738053cfde1414352cd62dab74",
                                            "size": 147044
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-freebsd.jar",
                                            "sha1": "f67b9b6c29451d8fea66db17aaba2f65e908c7e9",
                                            "size": 104415
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "sha1": "5821735d5ef23f6da8542887344e57eb181b7cac",
                                            "size": 143112
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-freebsd.jar",
                                            "sha1": "f5551338a1e2035ff747053f0e985dc93db1235c",
                                            "size": 226093
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "sha1": "2d73789ffd8962b38d9d599cc38b2383ce818c7a",
                                            "size": 15928
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.2.2:natives": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-freebsd.jar",
                                            "sha1": "acd5e1b9b9b99ce4d21867058ee468ee45a859e5",
                                            "size": 40104
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.1": {
                                        "name": "org.lwjgl:lwjgl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "sha1": "b86c3e4832426e8a6b466013b7cb34b40e9ce956",
                                            "size": 800127
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-freebsd.jar",
                                            "sha1": "610d14530e637564d97d74af7cb98a737e70b77b",
                                            "size": 96209
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "sha1": "e3f5dcb8e13f3a5ed3f740fd30a114cee2a80bc4",
                                            "size": 46430
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-freebsd.jar",
                                            "sha1": "5ee27f3bad4715067cef0630682da4bb5a1b88ac",
                                            "size": 157297
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "sha1": "9b74d3ea380c83353d42af43ad9659e04dabe84a",
                                            "size": 113103
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-freebsd.jar",
                                            "sha1": "3863f8268f5515c27f1364257f8a018f0c6afa79",
                                            "size": 597486
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "sha1": "2852ac7d9f6fc71349f1ce28e2708ff1977f18af",
                                            "size": 931960
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-freebsd.jar",
                                            "sha1": "579071d2a3714f5662522f7d3edf58e941580587",
                                            "size": 81028
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "sha1": "7e46ecdec85db8738053cfde1414352cd62dab74",
                                            "size": 147044
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-freebsd.jar",
                                            "sha1": "f67b9b6c29451d8fea66db17aaba2f65e908c7e9",
                                            "size": 104415
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "sha1": "5821735d5ef23f6da8542887344e57eb181b7cac",
                                            "size": 143112
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-freebsd.jar",
                                            "sha1": "f5551338a1e2035ff747053f0e985dc93db1235c",
                                            "size": 226093
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.1": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "sha1": "2d73789ffd8962b38d9d599cc38b2383ce818c7a",
                                            "size": 15928
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.1:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-freebsd.jar",
                                            "sha1": "acd5e1b9b9b99ce4d21867058ee468ee45a859e5",
                                            "size": 40104
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.2": {
                                        "name": "org.lwjgl:lwjgl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "sha1": "b86c3e4832426e8a6b466013b7cb34b40e9ce956",
                                            "size": 800127
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-freebsd.jar",
                                            "sha1": "610d14530e637564d97d74af7cb98a737e70b77b",
                                            "size": 96209
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "sha1": "e3f5dcb8e13f3a5ed3f740fd30a114cee2a80bc4",
                                            "size": 46430
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-freebsd.jar",
                                            "sha1": "5ee27f3bad4715067cef0630682da4bb5a1b88ac",
                                            "size": 157297
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "sha1": "9b74d3ea380c83353d42af43ad9659e04dabe84a",
                                            "size": 113103
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-freebsd.jar",
                                            "sha1": "3863f8268f5515c27f1364257f8a018f0c6afa79",
                                            "size": 597486
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "sha1": "2852ac7d9f6fc71349f1ce28e2708ff1977f18af",
                                            "size": 931960
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-freebsd.jar",
                                            "sha1": "579071d2a3714f5662522f7d3edf58e941580587",
                                            "size": 81028
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "sha1": "7e46ecdec85db8738053cfde1414352cd62dab74",
                                            "size": 147044
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-freebsd.jar",
                                            "sha1": "f67b9b6c29451d8fea66db17aaba2f65e908c7e9",
                                            "size": 104415
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "sha1": "5821735d5ef23f6da8542887344e57eb181b7cac",
                                            "size": 143112
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-freebsd.jar",
                                            "sha1": "f5551338a1e2035ff747053f0e985dc93db1235c",
                                            "size": 226093
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.2": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "sha1": "2d73789ffd8962b38d9d599cc38b2383ce818c7a",
                                            "size": 15928
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.2:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-freebsd.jar",
                                            "sha1": "acd5e1b9b9b99ce4d21867058ee468ee45a859e5",
                                            "size": 40104
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.3": {
                                        "name": "org.lwjgl:lwjgl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4.jar",
                                            "sha1": "b86c3e4832426e8a6b466013b7cb34b40e9ce956",
                                            "size": 800127
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl/3.3.4/lwjgl-3.3.4-natives-freebsd.jar",
                                            "sha1": "610d14530e637564d97d74af7cb98a737e70b77b",
                                            "size": 96209
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4.jar",
                                            "sha1": "e3f5dcb8e13f3a5ed3f740fd30a114cee2a80bc4",
                                            "size": 46430
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-jemalloc:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-jemalloc:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-jemalloc/3.3.4/lwjgl-jemalloc-3.3.4-natives-freebsd.jar",
                                            "sha1": "5ee27f3bad4715067cef0630682da4bb5a1b88ac",
                                            "size": 157297
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4.jar",
                                            "sha1": "9b74d3ea380c83353d42af43ad9659e04dabe84a",
                                            "size": 113103
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-openal:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-openal:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-openal/3.3.4/lwjgl-openal-3.3.4-natives-freebsd.jar",
                                            "sha1": "3863f8268f5515c27f1364257f8a018f0c6afa79",
                                            "size": 597486
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4.jar",
                                            "sha1": "2852ac7d9f6fc71349f1ce28e2708ff1977f18af",
                                            "size": 931960
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-opengl:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-opengl:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-opengl/3.3.4/lwjgl-opengl-3.3.4-natives-freebsd.jar",
                                            "sha1": "579071d2a3714f5662522f7d3edf58e941580587",
                                            "size": 81028
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4.jar",
                                            "sha1": "7e46ecdec85db8738053cfde1414352cd62dab74",
                                            "size": 147044
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-glfw:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-glfw:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-glfw/3.3.4/lwjgl-glfw-3.3.4-natives-freebsd.jar",
                                            "sha1": "f67b9b6c29451d8fea66db17aaba2f65e908c7e9",
                                            "size": 104415
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4.jar",
                                            "sha1": "5821735d5ef23f6da8542887344e57eb181b7cac",
                                            "size": 143112
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-stb:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-stb:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-stb/3.3.4/lwjgl-stb-3.3.4-natives-freebsd.jar",
                                            "sha1": "f5551338a1e2035ff747053f0e985dc93db1235c",
                                            "size": 226093
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4.jar",
                                            "sha1": "2d73789ffd8962b38d9d599cc38b2383ce818c7a",
                                            "size": 15928
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-tinyfd:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-tinyfd:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-tinyfd/3.3.4/lwjgl-tinyfd-3.3.4-natives-freebsd.jar",
                                            "sha1": "acd5e1b9b9b99ce4d21867058ee468ee45a859e5",
                                            "size": 40104
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-freetype:3.3.3": {
                                        "name": "org.lwjgl:lwjgl-freetype:3.3.4",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-freetype/3.3.4/lwjgl-freetype-3.3.4.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-freetype/3.3.4/lwjgl-freetype-3.3.4.jar",
                                            "sha1": "23f7bf165068ef2ca80ae1b79fd905af20498600",
                                            "size": 453489
                                          }
                                        }
                                      },
                                      "org.lwjgl:lwjgl-freetype:3.3.3:natives-linux": {
                                        "name": "org.lwjgl:lwjgl-freetype:3.3.4:natives-freebsd",
                                        "downloads": {
                                          "artifact": {
                                            "path": "org/lwjgl/lwjgl-freetype/3.3.4/lwjgl-freetype-3.3.4-natives-freebsd.jar",
                                            "url": "https://repo1.maven.org/maven2/org/lwjgl/lwjgl-freetype/3.3.4/lwjgl-freetype-3.3.4-natives-freebsd.jar",
                                            "sha1": "67d6775292771087cb3d5ba1239bf9bf42fb3bd7",
                                            "size": 1176759
                                          }
                                        }
                                      },
                                      "net.java.jinput:jinput-platform:2.0.5:natives": null,
                                      "com.mojang:text2speech:1.10.3:natives": null,
                                      "com.mojang:text2speech:1.11.3:natives": null,
                                      "com.mojang:text2speech:1.12.4:natives": null,
                                      "com.mojang:text2speech:1.13.9:natives-linux": null
                                    }
                                  }
                                  """;
}
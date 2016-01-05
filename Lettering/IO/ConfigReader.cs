﻿using System;
using System.IO;
using Lettering.Data;

namespace Lettering {
    internal class ConfigReader {
        private const string configPath = @"./configs/automation.cfg";
        private enum Sections { Void, Root, Types, Prefixes, Paths, Exports, Exceptions, Trims };

        internal static ConfigData ReadFile() {
            ConfigData config = new ConfigData();
            Sections curSection = Sections.Void;

            using(StreamReader sr = new StreamReader(configPath)) {
                int lineNumber = 0;
                string line;
                while(sr.Peek() > -1) {
                    line = sr.ReadLine().Trim();
                    ++lineNumber;

                    //NOTE(adam): do nothing if blank line or comment
                    if(invalidLine(line)) {
                        continue;
                    }

                    if(line[0] == '>') {
                        if(line.Contains("ROOT")) {
                            curSection = Sections.Root;
                        } else if(line.Contains("TYPES")) {
                            curSection = Sections.Types;
                        } else if(line.Contains("PREFIXES")) {
                            curSection = Sections.Prefixes;
                        } else if(line.Contains("PATHS")) {
                            curSection = Sections.Paths;
                        } else if(line.Contains("EXPORTS")) {
                            curSection = Sections.Exports;
                        } else if(line.Contains("EXCEPTIONS")) {
                            curSection = Sections.Exceptions;
                        } else if(line.Contains("TRIMS")) {
                            curSection = Sections.Trims;
                        } else {
                            Lettering.errors += "config " + lineNumber + ": Invalid section header\n";
                        }
                    } else {
                        switch(curSection) {
                            case Sections.Root:
                                config.rootPath = line;
                                break;
                            case Sections.Types:
                                if(!config.parseType(line)) Lettering.errors += "config " + lineNumber + ": Type parse error\n";
                                break;
                            case Sections.Prefixes:
                                if(!config.parsePrefix(line)) Lettering.errors += "config " + lineNumber + ": Prefix parse error\n";
                                break;
                            case Sections.Paths:
                                if(!config.parsePath(line)) Lettering.errors += "config " + lineNumber + ": Path parse error\n";
                                break;
                            case Sections.Exports:
                                if(!config.parseExport(line)) Lettering.errors += "config " + lineNumber + ": Export parse error\n";
                                break;
                            case Sections.Exceptions:
                                if(!config.parseException(line)) Lettering.errors += "config " + lineNumber + ": Exception parse error\n";
                                break;
                            case Sections.Trims:
                                if(!config.parseTrim(line)) Lettering.errors += "config " + lineNumber + ": Trim parse error\n";
                                break;
                            default:
                                Lettering.errors += "config " + lineNumber + ": Unspecified section\n";
                                break;
                        }
                    }
                }
            }

            return config;
        }

        private static bool invalidLine(string line) {
            return !(line.Length > 0 && line[0] != '#');
        }
    }
}

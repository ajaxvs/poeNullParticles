/**
* 
* Creates null particle files for Path of Exile 2.0.
* 
* HowTo:
* 
* 1. Export particle files from Content.ggpk using VisualGGPK. Atm it's "Metadata\Particles" folder.
* 2. Put this app near "Metadata" folder.
* 3. Launch once, wait "End" message.
* 4. Import created "nullParticles\Metadata" folder into Content.ggpk using VisualGGPK.
* 
* Dmitriy Kravtsov <ajaxvs@gmail.com>, 2015-10-11.
* 
*/

//========================================

#include <iostream>
#include <Windows.h>
#include <direct.h>
#include <stdio.h>
#include <algorithm>

using namespace std;

//========================================

const char nullBytesFile[] = { 0xFF, 0xFE, 0x30, 0x00, 0x0D, 0x00, 0x0A, 0x00 };
const string particleFileExtension = "pet";

//========================================

int createdFiles = 0;

//========================================

void out(const char * s) {
    cout << s << std::endl;
}

//==================================================

string getAppPath() {
    string sBuf = "";
    TCHAR szPath[MAX_PATH];
    if (GetModuleFileName(NULL, szPath, MAX_PATH)) {
        sBuf = szPath;
        size_t iPos = sBuf.rfind("/");
        if (iPos == string::npos) {
            iPos = sBuf.rfind("\\");
            if (iPos == string::npos) {
                return "";
            }
            sBuf = sBuf.substr(0, iPos + 1);
        }
    }
    return sBuf;
}

//==================================================

bool isDirExist(const string &filePath) {
    DWORD fileAtt = GetFileAttributesA(filePath.c_str());
    return (fileAtt != INVALID_FILE_ATTRIBUTES && fileAtt & FILE_ATTRIBUTE_DIRECTORY);
}

//==================================================

string cstr(const int i) {
    static char * c = new char[16];
    _itoa_s(i, c, 12, 10);
    string s = c;
    return s;
}

//========================================

string getFileExtension(const string fileName) {
    string lowerCase = fileName;
    std::transform(lowerCase.begin(), lowerCase.end(), lowerCase.begin(), ::tolower);
    size_t i = lowerCase.rfind('.', lowerCase.length());
    if (i != string::npos) {
        return(lowerCase.substr(i + 1, lowerCase.length() - i));
    } else {
        return("");
    }
}

//========================================

void createNullFile(const string &filePath) {
    FILE * pf;
    pf = fopen(filePath.c_str(), "wb");
    fwrite(nullBytesFile, sizeof(char), sizeof(nullBytesFile), pf);
    fclose(pf);
    createdFiles++;
    
    //out(filePath.c_str()); //debug
}

//========================================

void createFilesFromDir(const string src, const string dest) {
    WIN32_FIND_DATA fd;
    HANDLE h;

    //out("==="); //debug

    string folderFiles = src + "*.*";

    h = FindFirstFile(folderFiles.c_str(), &fd);
    if (h != INVALID_HANDLE_VALUE) {
        do {
            string fileName = fd.cFileName;
            if (!(fd.dwFileAttributes & FILE_ATTRIBUTE_DIRECTORY)) {
                string fileExtension = getFileExtension(fileName);
                if (fileExtension == particleFileExtension) {
                    createNullFile(dest + fileName);
                }
            } else {
                if (fileName != "." && fileName != "..") {
                    string newSrcDir = src + fileName + "\\";
                    string newDestDir = dest + fileName + "\\";
                    mkdir(newDestDir.c_str());
                    createFilesFromDir(newSrcDir, newDestDir);
                }
            }
        } while (FindNextFile(h, &fd));
        FindClose(h);
    }

    //out("==="); //debug
}

//========================================

void main() {
    out("poeNullParticles. Start.");

    const string metadataFolder = "Metadata\\";
    const string nullParticlesFolder = "nullParticles\\";

    string appPath = getAppPath();
    string metadataPath = appPath + metadataFolder;
    
    if (isDirExist(metadataPath)) {
        string nullParticlesPath = appPath + nullParticlesFolder;
        if (!isDirExist(nullParticlesPath)) {
            try {
                mkdir(nullParticlesPath.c_str());
                nullParticlesPath += metadataFolder;
                mkdir(nullParticlesPath.c_str());
                out("Creating null files, please wait...");

                createFilesFromDir(metadataPath, nullParticlesPath);

                string sDone = "Done. Created: " + cstr(createdFiles) + " null files";
                out(sDone.c_str());

            } catch (char * err) {
                out("Something gone wrong:");
                out(err);
            }
        } else {
            out("Stop. There's already nullParticles folder created.");
        }
    } else {
        out("Can't find Metadata folder.");
    }

    out("End. Press Enter to exit.");
    cin.ignore();
}

//========================================

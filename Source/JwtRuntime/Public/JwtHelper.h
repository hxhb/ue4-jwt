// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "jwt.h"

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"
#include "JwtHelper.generated.h"

/**
 * 
 */
UCLASS()
class JWTRUNTIME_API UJwtHelper : public UBlueprintFunctionLibrary
{
	GENERATED_BODY()
public:
	UFUNCTION(BlueprintCallable)
		static void DecodeToken(const FString& InToken);
};
